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
    public partial class Home : Form
    {
        int[] lid = new int[201];
        int lvl, id, lcnt;
        string[] lname = new string[201];

        public Home(int uid, int level)
        {
            lvl = level; id = uid;
            InitializeComponent();
            string str; lcnt = 1;
            lessonsLbx.Items.Add("Random");
            lname[0] = "Random";
            lid[0] = -1;
            str = "server=localhost; Database=smart; User ID=root;  Password=;";
            MySqlConnection new_con = new MySqlConnection(str);
            new_con.Open();
            MySqlCommand new_command = new MySqlCommand("SELECT * FROM lessons WHERE level="+lvl, new_con);
            MySqlDataReader reader = new_command.ExecuteReader();
            while (reader.Read())
            {
                lid[lcnt] = int.Parse(reader[0].ToString());
                lname[lcnt] = reader[1].ToString();
                lessonsLbx.Items.Add(lname[lcnt]);
                lcnt++;
            }
            new_con.Close();
            new_con.Open();
            MySqlCommand new_command1;
            if (lvl==1)
                new_command1 = new MySqlCommand("SELECT username, score1 FROM users ORDER BY score1 DESC", new_con);
            else
            {
                if (lvl == 2)
                    new_command1 = new MySqlCommand("SELECT username, score2 FROM users ORDER BY score2 DESC", new_con);
                else
                    new_command1 = new MySqlCommand("SELECT username, score3 FROM users ORDER BY score3 DESC", new_con);
            }
            MySqlDataReader reader1 = new_command1.ExecuteReader();
            while (reader1.Read())
            {
                string s = reader1[0].ToString();
                if (double.Parse(reader1[1].ToString())!=-1)
                topUsersLbx.Items.Add(s + " " + reader1[1].ToString());
            }
            new_con.Close();
        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            if (lessonsLbx.SelectedIndex == -1)
            {
                MessageBox.Show("Select lesson!");
                return;
            }
            if (lcnt == 1)
            {
                MessageBox.Show("Sorry lesson not faund!");
                return;
            }
            int index=lessonsLbx.SelectedIndex;
            exam ex=new exam(id, lvl, lid[index]);
            this.Hide();
            ex.ShowDialog();
            topUsersLbx.Items.Clear();


            /////////////////////////////
            string str = "server=localhost; Database=smart; User ID=root;  Password=;";
            MySqlConnection new_con = new MySqlConnection(str);
            new_con.Open();
            MySqlCommand new_command1;
            if (lvl == 1)
                new_command1 = new MySqlCommand("SELECT username, score1 FROM users ORDER BY score1 DESC", new_con);
            else
            {
                if (lvl == 2)
                    new_command1 = new MySqlCommand("SELECT username, score2 FROM users ORDER BY score2 DESC", new_con);
                else
                    new_command1 = new MySqlCommand("SELECT username, score3 FROM users ORDER BY score3 DESC", new_con);
            }
            MySqlDataReader reader1 = new_command1.ExecuteReader();
            while (reader1.Read())
            {
                string s = reader1[0].ToString();
                if (double.Parse(reader1[1].ToString()) != -1)
                    topUsersLbx.Items.Add(s + " " + reader1[1].ToString());
            }
            new_con.Close();
            /////////////////////////////
            this.Show();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
