﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using MySql.Data.Types;


namespace smartNew
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        // This is Clicked Login button//
        private void loginBtn_Click(object sender, EventArgs e)
        {
            string uname = unameTxt.Text;
            string pass = passTxt.Text;
            if (uname == "admin" && pass == "123") {
                Admin admin = new Admin();
                this.Hide();
                admin.ShowDialog();
                this.Show();
                return;
            }

            string str;
            str = "server=localhost; Database=smart; User ID=root;  Password=;";
            MySqlConnection new_con = new MySqlConnection(str);
            new_con.Open();
            MySqlCommand new_command = new MySqlCommand("SELECT * FROM users", new_con); 
            MySqlDataReader reader = new_command.ExecuteReader();
            while (reader.Read())
            {
                if(reader[1].ToString() == uname && reader[2].ToString() == pass)
                {
                    begin H = new begin(int.Parse(reader[0].ToString()));
                    this.Hide(); new_con.Close();
                    H.ShowDialog();
                    this.Show();
                    return;
                }
            }
            MessageBox.Show("Username or password is wrong!");
        }

        //this is Clicked Register Button//////
        private void registerBtn_Click(object sender, EventArgs e)
        {
            string uname = unameTxt.Text;
            string pass = passTxt.Text;
            string str;
            str = "server=localhost; Database=smart; User ID=root;  Password=;";
            MySqlConnection new_con = new MySqlConnection(str);
            new_con.Open();
            string query = "INSERT INTO `smart`.`users` (`username` ,`password` ,`score1`, `score2`, `score3`) VALUES ('" + uname + "',  '" + pass + "',  -1, -1, -1)";
            MySqlCommand new_command = new MySqlCommand(query, new_con);
            new_command.ExecuteNonQuery();
            new_con.Close();
            unameTxt.Text = "";
            passTxt.Text = "";
            MessageBox.Show("Registeration successful!");
        }


       

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
