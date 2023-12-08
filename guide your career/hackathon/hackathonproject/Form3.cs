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
    public partial class Quizcat : Form
    {
        public Quizcat()
        {
            InitializeComponent();
        }

        private void generalk_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void Science_Click(object sender, EventArgs e)
        {
            sciencepage1 scp1 = new sciencepage1();
            scp1.Show();
            this.Hide();
        }

        private void previous1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
