using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace GoalTracker
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            username.Focus();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (validate() == 1)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=DESKTOP-QFL9PM8\SQLEXPRESS;Initial Catalog=rbdevdb;Integrated Security=True";
                /* in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. */
                string Query = "SELECT distinct(username) FROM users WHERE username='" + username.Text + "' AND password='" + password.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(Query, con);
                DataTable dt = new DataTable(); //this is creating a virtual table  
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("Login success");
                }
                else
                {
                    MessageBox.Show("Invalid credentials !");
                    username.Text = "";
                    password.Text = "";
                    username.Focus();
                }
            }
        }

        private int validate()
        {
            if (username.Text == "" && password.Text == "")
            {
                MessageBox.Show("Please enter username and password !");
                username.Focus();
                return 0;
            }
            else if (username.Text == "")
            {
                MessageBox.Show("Please Enter a username !");
                username.Focus();
                return 0;
            }
            else if(password.Text == "")
            {
                MessageBox.Show("Please Enter a password !");
                password.Focus();
                return 0;
            }
            else
                return 1;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Do you want to exit the application?", "Cancel", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            this.Hide();
            r.Show();
        }
    }
}