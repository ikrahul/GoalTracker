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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Do you want to exit?", "Cancel", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                this.Hide();
                Login l = new Login();  
                l.Show();   
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-QFL9PM8\SQLEXPRESS;Initial Catalog=rbdevdb;Integrated Security=True";
            con.Open(); 
            SqlCommand cmd = new SqlCommand("INSERT INTO users VALUES(@username , @password, @fname, @lname,@city,@profession,@mob)",con);
            cmd.Parameters.AddWithValue("username", username.Text);
            cmd.Parameters.AddWithValue("password", password.Text);
            cmd.Parameters.AddWithValue("fname", fname.Text);
            cmd.Parameters.AddWithValue("lname", lname.Text);
            cmd.Parameters.AddWithValue("city", city.Text);
            cmd.Parameters.AddWithValue("profession", profession.Text);
            cmd.Parameters.AddWithValue("mob", mob.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Your Account is created . Please login now.");
        }
    }
}
