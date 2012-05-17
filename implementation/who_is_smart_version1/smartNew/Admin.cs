using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace smartNew
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int check = 1;
            if (radioButton2.Checked) check = 2;
            if (radioButton3.Checked) check = 3;
            string str = textBox1.Text;
            if (str != "")
            {
                this.Hide();
                add dd = new add(0, check, str);
                dd.ShowDialog();
                this.Show();
            }
        }
    }
}
