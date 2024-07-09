using System;
using System.Data;
using System.Data.SqlClient;



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
        public RegisterTeams()
        {
            InitializeComponent();
            FillDGA();

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
                            MessageBox.Show("Lojtaret u regjistruan!");
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
                            MessageBox.Show("Teams Registered!");
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
        public void FillDGA()
        {
            string connectionString = @"Server=OLTI-PC;Database=TableFootball;Trusted_Connection=True;";
           

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT winner as Team, COUNT(*) AS wins\r\n   FROM playedGames\r\n   WHERE DatePlayed >= DATEADD(DAY, -7, GETDATE())\r\n   GROUP BY winner\r\n   ORDER BY wins DESC";
                SqlDataAdapter da = new SqlDataAdapter(query , conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView.DataSource = dt;

                conn.Close();
            }
        }

    }
}
