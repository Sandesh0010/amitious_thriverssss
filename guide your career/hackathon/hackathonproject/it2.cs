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
    public partial class it2 : Form
    {
        public it2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BIT1 bIT1 = new BIT1(); 
            bIT1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BIT3 bIT3 = new BIT3();
            bIT3.Show();
            this.Hide();
        }
    }
}
