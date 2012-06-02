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
    public partial class exam : Form
    {
        int count = 0, score = 0, lvl, id;
        string[] userQuestion = new string[1001];
        string[] userAnswer = new string[1001];
        int[] index = new int[11];
        int N = 0;

        public exam(int uid, int level, int lid)
        {
            InitializeComponent();
            lvl = level; id = uid;
            label1.Text = "Problem 0";
            string str = "server=localhost; Database=smart; User ID=root;  Password=;";
            MySqlConnection new_con = new MySqlConnection(str);
            new_con.Open();
            MySqlCommand new_command;
            if (lid == -1)
            {
                new_command = new MySqlCommand("SELECT question, answer FROM problems WHERE level=" + lvl, new_con);
            }
            else
            {
                new_command = new MySqlCommand("SELECT question, answer FROM problems WHERE l_id=" + lid, new_con);
            }
            MySqlDataReader reader = new_command.ExecuteReader();
            while (reader.Read())
            {
                userQuestion[N] = reader[0].ToString();
                userAnswer[N] = reader[1].ToString();
                N++;
            }
            new_con.Close();

            if (lid == -1)
            {
                Random r = new Random();
                for (int i = 0; i < 10; i++)
                {
                    index[i] = r.Next() % N;
                }
            }
            else
            {
                for (int i = 0; i < 10; i++)
                    index[i] = i;
            }
            label2.Text = userQuestion[index[0]];
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // USers next junp to task  //
        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == userAnswer[index[count]]) score++;
            if (count == N-1)
            {
                this.Hide();
                result res = new result(id, lvl, score, N);
                res.ShowDialog();
                this.Close();
            }
            else
            {
                count++;
                label1.Text = "Problem " + count.ToString();
                label2.Text = userQuestion[count];
                textBox1.Text = "";
            }
        }
    }
}
