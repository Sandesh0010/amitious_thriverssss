using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hackathonproject
{
    public partial class BIT1 : Form
    {
        public BIT1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            it2 it2 = new it2();  
            it2.Show();
            this.Hide();
        }

        private void m1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();  
            form1.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
