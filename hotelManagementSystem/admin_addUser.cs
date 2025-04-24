﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace hotelManagementSystem
{
    public partial class admin_addUser : UserControl
    {
        private string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\arkan\Documents\hotelmanagement.mdf;Integrated Security=True;Connect Timeout=30";

        public admin_addUser()
        {
            InitializeComponent();
            displayData();
        }

        public void displayData()
        {
            usersData uData = new usersData();
            dataGridView1.DataSource = uData.listUserData();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void addUser_addBtn_Click(object sender, EventArgs e)
        {
            if(addUser_username.Text == "" || addUser_password.Text == "" 
                || addUser_role.SelectedIndex == -1 || addUser_status.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using(SqlConnection connect = new SqlConnection(conn))
                {
                    connect.Open();

                    string checkUsern = "SELECT username FROM users WHERE username = @usern";

                    using (SqlCommand checkU = new SqlCommand(checkUsern, connect))
                    {
                        checkU.Parameters.AddWithValue("@usern", addUser_username.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(checkU);
                        DataTable table = new DataTable();

                        adapter.Fill(table);

                        if(table.Rows.Count > 0)
                        {
                            string tempUsern = addUser_username.Text.Substring(0, 1).ToUpper() + addUser_username.Text.Substring(1);
                            MessageBox.Show($"{tempUsern} is existing alerdy", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if(addUser_password.Text.Length < 8) {
                            MessageBox.Show("Invalid Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string insertData = "INSERT INTO users(username, password, role, status, date_register) VALUES (@usern, @pass, @role, @status, @date)";
                            using(SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                cmd.Parameters.AddWithValue("@usern", addUser_username.Text.Trim());
                                cmd.Parameters.AddWithValue("@pass", addUser_password.Text.Trim());
                                cmd.Parameters.AddWithValue("@role", addUser_role.SelectedItem.ToString());
                                cmd.Parameters.AddWithValue("@status", addUser_status.SelectedItem.ToString());

                                DateTime today = DateTime.Today;

                                cmd.Parameters.AddWithValue("@date", today);

                                cmd.ExecuteNonQuery();
                                clearFields();

                                MessageBox.Show("Added succesfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                
                            }
                        }
                    }
                }
            
            }
        }

        public void clearFields() 
        {
            addUser_username.Text = "";
            addUser_password.Text = "";
            addUser_role.SelectedIndex = -1;
            addUser_status.SelectedIndex = -1;

        }
        private void addUser_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void addUser_updateBtn_Click(object sender, EventArgs e)
        {
            if (addUser_username.Text == "" || addUser_password.Text == ""
               || addUser_role.SelectedIndex == -1 || addUser_status.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure want to update ID: " + getID + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(conn))
                    {
                        connect.Open();

                        string updateData = "UPDATE users SET password = @pass, role = @role, status = @status WHERE username = @usern";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@pass", addUser_password.Text.Trim());
                            cmd.Parameters.AddWithValue("@role", addUser_role.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@status", addUser_status.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@usern", addUser_username.Text.Trim());

                            cmd.ExecuteNonQuery();
                            displayData();

                            MessageBox.Show("Update succesfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private int getID;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                getID = (int)row.Cells[0].Value;
                addUser_username.Text = row.Cells[1].Value.ToString();
                addUser_password.Text = row.Cells[2].Value.ToString();
                addUser_role.Text = row.Cells[3].Value.ToString();
                addUser_status.Text = row.Cells[4].Value.ToString();
            }
        }

        private void addUser_deleteBtn_Click(object sender, EventArgs e)
        {
            if (addUser_username.Text == "" || addUser_password.Text == ""
              || addUser_role.SelectedIndex == -1 || addUser_status.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure want to delete ID: " + getID + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(conn))
                    {
                        connect.Open();

                        string updateData = "DELETE FROM users WHERE username = @usern";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@pass", addUser_password.Text.Trim());
                            cmd.Parameters.AddWithValue("@role", addUser_role.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@status", addUser_status.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@usern", addUser_username.Text.Trim());

                            cmd.ExecuteNonQuery();
                            displayData();

                            MessageBox.Show("Delete succesfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
