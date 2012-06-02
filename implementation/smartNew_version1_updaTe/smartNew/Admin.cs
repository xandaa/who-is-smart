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

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Admin git the lesson name and add the lessons tasks//
        private void nextBtn_Click(object sender, EventArgs e)
        {
            int check = 1;
            if (mediumRBtn.Checked) check = 2;
            if (hardRBtn.Checked) check = 3;
            string str = lessonNameTxt.Text;
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
