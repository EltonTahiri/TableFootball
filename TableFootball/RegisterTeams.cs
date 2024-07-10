using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Timer = System.Threading.Timer;



namespace TableFootball
{
    public partial class RegisterTeams : Form
    {
        public static string E1Sulm;
        public static string E1Port;

        public static string E2Sulm;
        public static string E2Port;

        public static string Team1;
        public static string Team2;
        string valueDaysToCheck;
        private System.Windows.Forms.Timer timer3;

        public RegisterTeams()
        {
            InitializeComponent();
            getCheckedValue();
            FillDGA(valueDaysToCheck);

            timer2.Start();

        }

        public void Fill()
        {
            Team1 = txtTeam1.Text;
            Team2 = txtTeam2.Text;
            E1Sulm = txtE1Sulm.Text;
            E1Port = txtE1Port.Text;

            E2Sulm = txtE2Sulm.Text;
            E2Port = txtE2Port.Text;
        }





        public void btnContinue_Click(object sender, EventArgs e)
        {
            if (txtE1Port.Text == "" || txtE1Sulm.Text == "" || txtE2Sulm.Text == "" || txtE2Port.Text == "" || txtTeam1.Text == "" || txtTeam2.Text == "")
            {
                MessageBox.Show("Ju lutem mbushini te gjitha te dhenat");
            }

            else
            {
                Fill();
                AddPlayerDb();
                AddTeamsDb();

            }

            ResultFrom resultFrom = new ResultFrom(Team1, Team2, E1Sulm, E1Port, E2Sulm, E2Port);
            this.Hide();
            resultFrom.ShowDialog();
            timer2.Stop();



        }


        public void AddPlayerDb()
        {
            string connectionString = @"Server=OLTI-PC;Database=TableFootball;Trusted_Connection=True;";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO [dbo].[player] (name) VALUES (@name)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (!CheckPlayerExists(E1Port) && !CheckPlayerExists(E1Sulm) && !CheckPlayerExists(E2Port) && !CheckPlayerExists(E2Sulm))
                        {
                            cmd.Parameters.AddWithValue("@name", E1Port);
                            cmd.ExecuteNonQuery();
                            cmd.Parameters.Clear();

                            cmd.Parameters.AddWithValue("@name", E1Sulm);
                            cmd.ExecuteNonQuery();
                            cmd.Parameters.Clear();

                            cmd.Parameters.AddWithValue("@name", E2Port);
                            cmd.ExecuteNonQuery();
                            cmd.Parameters.Clear();

                            cmd.Parameters.AddWithValue("@name", E2Sulm);
                            cmd.ExecuteNonQuery();

                        }


                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void AddTeamsDb()
        {
            string connectionString = @"Server=OLTI-PC;Database=TableFootball;Trusted_Connection=True;";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO [dbo].[Teams] (teamName, attacker, defender) VALUES (@teamName ,@attacker , @defender )";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (!CheckTeamExists(Team1) && !CheckTeamExists(Team2))
                        {
                            cmd.Parameters.AddWithValue("@teamName", Team1);
                            cmd.Parameters.AddWithValue("@attacker", E1Sulm);
                            cmd.Parameters.AddWithValue("@defender", E1Port);
                            cmd.ExecuteNonQuery();
                            cmd.Parameters.Clear();

                            cmd.Parameters.AddWithValue("@teamName", Team2);
                            cmd.Parameters.AddWithValue("@attacker", E2Sulm);
                            cmd.Parameters.AddWithValue("@defender", E2Port);
                            cmd.ExecuteNonQuery();
                        }


                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool CheckPlayerExists(string playerName)
        {
            string connectionString = @"Server=OLTI-PC;Database=TableFootball;Trusted_Connection=True;";
            string query = "SELECT COUNT(*) FROM player WHERE name = @name";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", playerName);
                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool CheckTeamExists(string playerName)
        {
            string connectionString = @"Server=OLTI-PC;Database=TableFootball;Trusted_Connection=True;";
            string query = "SELECT COUNT(*) FROM Teams WHERE teamName = @teamName";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@teamName", playerName);
                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }



        public void btnClear_Click(object sender, EventArgs e)
        {
            txtE1Port.Text = "";
            txtE1Sulm.Text = "";
            txtE2Port.Text = "";
            txtE2Sulm.Text = "";
        }
        public void FillDGA(string daysToCheck)
        {
            string connectionString = @"Server=OLTI-PC;Database=TableFootball;Trusted_Connection=True;";
            string query = @"
        SELECT winner AS Team, COUNT(*) AS wins
        FROM playedGames
        WHERE DatePlayed >= DATEADD(DAY, -@daysToCheck, GETDATE())
        GROUP BY winner
        ORDER BY wins DESC";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@daysToCheck", int.Parse(daysToCheck));

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView.DataSource = dt;
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void Form_Load(object sender, EventArgs e)
        {
            timer2.Interval = 3500;
            timer2.Start();
        }

        private void Timer3_Tick(object sender, EventArgs e)
        {
            FillDGA(valueDaysToCheck);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            getCheckedValue();
            FillDGA(valueDaysToCheck);

        }

        public void getCheckedValue()
        {

            if (checkBox1.Checked)
            {
                valueDaysToCheck = "1";
            }
            else if (checkBox2.Checked)
            {
                valueDaysToCheck = "7";
            }
            else if (checkBox3.Checked)
            {
                valueDaysToCheck = "30";
            }
            else if (checkBox4.Checked)
            {
                valueDaysToCheck = "182";
            }
            else if (checkBox5.Checked)
            {
                valueDaysToCheck = "365";
            }
            else
            {
                valueDaysToCheck = "365";
            }



        }


    }
}
