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

        private void button1_Click(object sender, EventArgs e)
        {
            Home hm = new Home(id, 1);
            hm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home hm = new Home(id, 2);
            hm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home hm = new Home(id, 3);
            //this.Hide();
            hm.ShowDialog();
            //this.ShowDialog();
        }
    }
}
