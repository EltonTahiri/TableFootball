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
        public RegisterTeams()
        {
            InitializeComponent();
        }

        public void FillTextFields()
        {
            E1Sulm = txtE1Sulm.Text;
            E1Port = txtE1Port.Text;

            E2Sulm = txtE2Sulm.Text;
            E2Port = txtE2Port.Text;
        }

        public void btnContinue_Click(object sender, EventArgs e)
        {
            if (txtE1Port.Text == "" || txtE1Sulm.Text == "" || txtE2Port.Text == "" || txtE2Port.Text == "")
            {
                MessageBox.Show("Ju lutem mbushini te gjitha te dhenat");
            }

            else
            {
                FillTextFields();
                AddPlayerDb();
            }

        }


        public void AddPlayerDb()
        {
            string connectionString = @"Server=DESKTOP-S0U0CDO\SQLEXPRESS;Database=TableFootball;Trusted_Connection=True;";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO [dbo].[Players] ([name]) VALUES (@name)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                       
                        if (!CheckPlayerExists(E1Port))
                        {
                            cmd.Parameters.AddWithValue("@name", E1Port);
                            cmd.ExecuteNonQuery();
                            cmd.Parameters.Clear();
                            MessageBox.Show("Lojtari u regjistrua!");
                        }
                        else
                        {
                            MessageBox.Show("Lojtari me emrin:" + E1Port+" ekziston");
                        }
                        
                        if (!CheckPlayerExists(E1Sulm))
                        {
                            cmd.Parameters.AddWithValue("@name", E1Sulm);
                            cmd.ExecuteNonQuery();
                            cmd.Parameters.Clear();
                            MessageBox.Show("Lojtari u regjistrua!");
                        }
                        else
                        {
                            MessageBox.Show("Lojtari me emrin:" + E1Sulm + " ekziston");
                        }


                        if (!CheckPlayerExists(E2Port))
                        {
                            cmd.Parameters.AddWithValue("@name", E2Port);
                            cmd.ExecuteNonQuery();
                            cmd.Parameters.Clear();
                            MessageBox.Show("Lojtari u regjistrua!");
                        }
                        else
                        {
                            MessageBox.Show("Lojtari me emrin:" + E2Port + " ekziston");
                        }


                        if (!CheckPlayerExists(E2Sulm))
                        {
                            cmd.Parameters.AddWithValue("@name", E2Sulm);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Lojtari u regjistrua!");
                        }
                        else
                        {
                            MessageBox.Show("Lojtari me emrin:" + E2Sulm + " ekziston");
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
            string connectionString = @"Server=DESKTOP-S0U0CDO\SQLEXPRESS;Database=TableFootball;Trusted_Connection=True;";
            string query = "SELECT COUNT(*) FROM Players WHERE name = @name";

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

        public void btnClear_Click(object sender, EventArgs e)
        {
            txtE1Port.Text = "";
            txtE1Sulm.Text = "";
            txtE2Port.Text = "";
            txtE2Sulm.Text = "";
        }
    }
}
