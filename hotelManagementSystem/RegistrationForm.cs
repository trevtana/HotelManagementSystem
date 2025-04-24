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

namespace hotelManagementSystem
{
    public partial class RegistrationForm : Form
    {
        private string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\arkan\Documents\hotelmanagement.mdf;Integrated Security=True;Connect Timeout=30";

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void register_signinBtn_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }

        private void register_showpass_CheckedChanged(object sender, EventArgs e)
        {
            register_password.PasswordChar = register_showpass.Checked ? '\0' : '*';
            register_cpassword.PasswordChar = register_showpass.Checked ? '\0' : '*';
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (register_username.Text == "" || register_password.Text == "" || register_cpassword.Text == "")
                {
                    MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (register_password.Text.Length < 8)
                {
                    MessageBox.Show("Password must be at least 8 characters", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (register_password.Text != register_cpassword.Text)
                {
                    MessageBox.Show("Password does not match", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (SqlConnection connect = new SqlConnection(conn))
                {
                    connect.Open();
                    //MessageBox.Show("Database Connected!", "Debug Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    string checkUsern = "SELECT username FROM users WHERE username = @usern";
                    using (SqlCommand checkU = new SqlCommand(checkUsern, connect))
                    {
                        checkU.Parameters.AddWithValue("@usern", register_username.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(checkU);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count != 0)
                        {
                            MessageBox.Show("Username already exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    string query = "INSERT INTO users (username, password, role, status, date_register) VALUES (@usern, @pass, @role, @status, @regDate)";

                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@usern", register_username.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", register_password.Text.Trim());
                        cmd.Parameters.AddWithValue("@role", "Staff");
                        cmd.Parameters.AddWithValue("@status", "Active");

                        cmd.Parameters.AddWithValue("@regDate", DateTime.Now);

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Registered successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to register", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Exception Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void register_username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
