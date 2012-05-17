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
    public partial class add : Form
    {
        int cnt, lvl; string nm;
        string[] a = new string[11];
        string[] q = new string[11];
        public add(int count, int level, string name)
        {
            cnt = count; lvl = level; nm = name;
            label1=new Label();
            label1.Text = "Problem 0";
            label1.Enabled = true;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cnt == 9)
            {
                if (textBox1.Text == "" || textBox2.Text == "")
                {
                    MessageBox.Show("Question or answer is wrong!");
                    return;
                }
                q[cnt] = textBox1.Text;
                a[cnt] = textBox2.Text;
                string str;
                str = "server=localhost; Database=smart; User ID=root;  Password=;";
                MySqlConnection new_con = new MySqlConnection(str);
                new_con.Open();

                int l_id; Random r=new Random();
                while (true)
                {
                    l_id=r.Next() % 10000;
                    int f=0;
                    MySqlCommand new_command = new MySqlCommand("SELECT * FROM `smart`.`problems` WHERE l_id="+l_id, new_con); 
                    MySqlDataReader reader = new_command.ExecuteReader();
                    while (reader.Read())
                    {
                        f++; break;
                    }
                 if (f==0) break;
                }

                for (int i = 0; i < 10; i++)
                {
                    new_con.Close(); new_con.Open();
                    string query = "INSERT INTO `smart`.`problems` (`l_id`, `level`, `question`, `answer`) VALUES (" + l_id + ", " + lvl + ", '" + q[i] + "', '" + a[i] + "')";
                    MySqlCommand new_command = new MySqlCommand(query, new_con);
                    new_command.ExecuteNonQuery();
                }

                new_con.Close(); new_con.Open();
                string query1 = "INSERT INTO `smart`.`lessons` (`l_id`, `l_name`, `level`) VALUES (" + l_id + ", '" + nm + "', '" + lvl + "')";
                MySqlCommand new_command1 = new MySqlCommand(query1, new_con);
                new_command1.ExecuteNonQuery();
                new_con.Close();

                MessageBox.Show("Successful.");
                this.Close();
            }
            else
            {
                if (textBox1.Text != "" && textBox2.Text != "")
                {
                    q[cnt] = textBox1.Text;
                    a[cnt] = textBox2.Text;
                    cnt++;
                    textBox1.Text = q[cnt];
                    textBox2.Text = a[cnt];
                    label1.Enabled = true;
                    label1.Text = "Problem " + cnt.ToString();
                }
                else
                    MessageBox.Show("Question or answer is wrong!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cnt == 0)
            {
                this.Close();
            }
            else
            {
                q[cnt] = textBox1.Text;
                a[cnt] = textBox2.Text;
                cnt--;
                textBox1.Text = q[cnt];
                textBox2.Text = a[cnt];
                label1.Text = "Problem "+cnt.ToString();
                label1.Enabled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string query1 = "INSERT INTO `smart`.`lessons` (`l_id`, `l_name`, `level`) VALUES (" + l_id + ", '" + nm + "', '" + lvl + "')";
            MySqlCommand new_command1 = new MySqlCommand(query1, new_con);
            new_command1.ExecuteNonQuery();
        
            for (int i = 0; i < cnt; i++)
            {
                new_con.Close(); new_con.Open();
                string query = "INSERT INTO `smart`.`problems` (`l_id`, `level`, `question`, `answer`) VALUES (" + l_id + ", " + lvl + ", '" + q[i] + "', '" + a[i] + "')";
                MySqlCommand new_command = new MySqlCommand(query, new_con);
                new_command.ExecuteNonQuery();
            }
            new_con.Close();

            MessageBox.Show("Successful.");
            this.Close();
        }
    }
}
