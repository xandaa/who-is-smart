using System;
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
    public partial class result : Form
    {
        public result(int uid, int level, int score)
        {
            score *= 10;
            InitializeComponent();
            label1.Text = score.ToString()+"%";
            string str = "server=localhost; Database=smart; User ID=root;  Password=;";
            MySqlConnection new_con = new MySqlConnection(str);
            new_con.Open();

            MySqlCommand new_command;
            if (level == 1) new_command = new MySqlCommand("SELECT score1 FROM users WHERE id="+uid, new_con);
            else
            {
                if (level == 2) new_command = new MySqlCommand("SELECT score2 FROM users WHERE id="+uid, new_con);
                else new_command = new MySqlCommand("SELECT score3 FROM users WHERE id="+uid, new_con);
            }
            MySqlDataReader reader = new_command.ExecuteReader();
            double oldScore = -1, newScore;
            while (reader.Read())
            {
                oldScore = double.Parse(reader[0].ToString());
                break;
            }
            if (oldScore == -1)
            {
                newScore = score;
            }
            else
            {
                newScore = (oldScore + score) / 2;
            }
            new_con.Close();
            new_con.Open();

            if (level == 1) new_command = new MySqlCommand("UPDATE `smart`.`users` SET `score1` = " + newScore + " WHERE `users`.`id` = " + uid, new_con);
            else
            {
                if (level == 2) new_command = new MySqlCommand("UPDATE `smart`.`users` SET `score2` = " + newScore + " WHERE `users`.`id` = " + uid, new_con);
                else new_command = new MySqlCommand("UPDATE `smart`.`users` SET `score3` = " + newScore + " WHERE `users`.`id` = " + uid, new_con);
            }
            new_command.ExecuteNonQuery();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
