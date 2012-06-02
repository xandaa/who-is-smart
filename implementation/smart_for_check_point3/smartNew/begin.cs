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
    public partial class begin : Form
    {
        private int id;
        public begin(int uid)
        {
            id = uid;
            InitializeComponent();
        }

        //easy lavel id is 1. we use it next form//
        private void easyBtn_Click(object sender, EventArgs e)
        {
            Home hm = new Home(id, 1);
            hm.ShowDialog();
        }

        //medium lavel id is 2. we use it next form//
        private void mediumBtn_Click(object sender, EventArgs e)
        {
            Home hm = new Home(id, 2);
            hm.ShowDialog();
        }

        //hard lavel id is 3. we use it next form//
        private void hardBtn_Click(object sender, EventArgs e)
        {
            Home hm = new Home(id, 3);
            //this.Hide();
            hm.ShowDialog();
            //this.ShowDialog();
        }


        
    }
}
