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
    public partial class sub : Form
    {
        public sub()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Science1 science1 = new Science1();
            science1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
           management1 management1 = new management1();
            management1.Show();
        }
    }
}
