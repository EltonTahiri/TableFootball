using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Timers;

namespace TableFootball
{
    public partial class ResultFrom : Form
    {
        public string _Team1;
        public string _Team2;
        public string _E1sulm;
        public string _E2sulm;
        public string _E1port;
        public string _E2port;
        public string team1Score;
        public string team2Score;
        private int _ticks;
        public string winner;
        private int _minutes;
        private int _ticksDisplay;
        public int team1wins;
        private int team2wins;
        DateTime dt = DateTime.Now;


        public ResultFrom(string Team1, string Team2, string E1sulm, string E1Port, string E2sulm, string E2Port)
        {
            InitializeComponent();
            _Team1 = Team1;
            _Team2 = Team2;
            _E1port = E1Port;
            _E2port = E2Port;
            _E1sulm = E1sulm;
            _E2sulm = E2sulm;
            MyTimer.Enabled = true;
            FillTeamsAndPlayers();
            getTeam1Wins(_Team1);
            getTeam2Wins(_Team2);
        }
        public void FillTeamsAndPlayers()
        {
            Team1.Text = _Team1;
            Team2.Text = _Team2;
            E1sulm.Text = _E1sulm;
            E1port.Text = _E1port;
            E2Port.Text = _E2port;
            E2sulm.Text = _E2sulm;

        }
        public void Score()
        {
            team1Score = txtTeam1Score.Text;
            team2Score = txtTeam2Score.Text;

        }


        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (txtTeam1Score.Text == "" || txtTeam2Score.Text == "")
            {
                MessageBox.Show("Ju lutem mbushini te gjitha te dhenat");
            }
            else
            {
                Score();

                int score1 = Int32.Parse(team1Score);
                int score2 = Int32.Parse(team2Score);
                if (score1 > score2)
                {
                    winner = Team1.Text;
                }
                else
                {
                    winner = Team2.Text;
                }
                MyTimer.Stop();
                AddGameToDb();

                RegisterTeams registerTeams = new RegisterTeams();
                this.Hide();
                registerTeams.ShowDialog();
            }
        }



        public void AddGameToDb()
        {
            string connectionString = @"Server=OLTI-PC;Database=TableFootball;Trusted_Connection=True;";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO [dbo].[PlayedGames] (Team1 , Team2 , Team1Score , Team2Score , DatePlayed , Timer , Winner) VALUES (@Team1 , @Team2 , @Team1Score , @Team2Score ,@DatePlayed , @Timer , @winner )";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Team1", _Team1);
                        cmd.Parameters.AddWithValue("@Team2", _Team2);
                        cmd.Parameters.AddWithValue("@Team1Score", team1Score);
                        cmd.Parameters.AddWithValue("@Team2Score", team2Score);
                        cmd.Parameters.AddWithValue("@DatePlayed", dt);
                        cmd.Parameters.AddWithValue("@Timer", _ticks);
                        cmd.Parameters.AddWithValue("@winner", winner);
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();

                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            _ticks++;
            _ticksDisplay++;



            TimerCounter.Text = _ticksDisplay.ToString();
            if (_ticksDisplay % 60 == 0)
            {
                label1.Text = ":";
                _ticksDisplay = 0;
                _minutes++;
                minutes.Text = _minutes.ToString();

            }
        }
        // (team1Score / (team1Score + team2Score)) * 100;



        public void getTeam1Wins(string team1)
        {
            // (team1Score / (team1Score + team2Score)) * 100;
            string connectionString = @"Server=OLTI-PC;Database=TableFootball;Trusted_Connection=True;";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                         SELECT COUNT(*) AS wins
                         FROM playedGames
                         WHERE winner = @team1";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@team1", team1);
                        var result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            team1wins = Convert.ToInt32(result);
                        }
                        else
                        {
                            MessageBox.Show("No wins found for the team.");
                        }
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        public void getTeam2Wins(string team2)
        {
            // (team1Score / (team1Score + team2Score)) * 100;
            string connectionString = @"Server=OLTI-PC;Database=TableFootball;Trusted_Connection=True;";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                         SELECT COUNT(*) AS wins
                         FROM playedGames
                         WHERE winner = @team2";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@team2", team2);
                        var result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            team2wins = Convert.ToInt32(result);
                            getPropability();
                            getOdds();

                        }
                        else
                        {
                            MessageBox.Show("No wins found for the team.");
                        }
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        public void getPropability()
        {
            if (team1wins + team2wins > 0)
            {
                WinPercTeam1.Text = ((team1wins / (double)(team1wins + team2wins)) * 100).ToString("F2") + "%";
                WinPercTeam2.Text = ((team2wins / (double)(team2wins + team1wins)) * 100).ToString("F2") + "%";
            }
            else
            {
                WinPercTeam1.Text = "0%";
                WinPercTeam2.Text = "0%";
            }
        }


        public void getOdds()
        {
            if (team1wins + team2wins > 0)
            {
                odds1.Text = (1 / (team1wins / (double)(team1wins + team2wins))).ToString("0.00");
                if (team2wins != 0 && team1wins != 0)
                {
                    if (team1wins >= team2wins)
                    {
                        oddsX.Text = (team1wins / (double)team2wins).ToString("0.00");
                    }
                    else
                    {
                        oddsX.Text = (team2wins / (double)team1wins).ToString("0.00");
                    }
                }
                odds2.Text = (1 / (team2wins / (double)(team1wins + team2wins))).ToString("0.00");
            }
            else
            {
                odds1.Text = "0";
                oddsX.Text = "0";
                odds2.Text = "0";
            }
        }
    }
}
