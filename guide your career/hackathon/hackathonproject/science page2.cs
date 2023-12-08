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
    public partial class prev1 : Form
    {
        public prev1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ansa5.Text = "Incorrect!!The correct answer is Micro wave.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ansa5.Text = "Incorrect!!The correct answer is Micro wave.";
        }

        private void camel_Click(object sender, EventArgs e)
        {
            ansa5.Text = "Incorrect!!The correct answer is Micro wave.";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ansa5.Text = "Correct!!";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ansa6.Text = "Incorrect!!The correct answer is H20.";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ansa6.Text = "Incorrect!!The correct answer is H2O.";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ansa6.Text = "Incorrect!!The correct answer is H2O.";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ansa6.Text = "Correct!!";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            ansa7.Text = "Incorrect!!The correct answer is Ampere.";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ansa7.Text = "Incorrect!!The correct answer is Ampere.";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ansa7.Text = "Incorrect!!The correct answer is Ampere.";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ansa7.Text = "Correct!!";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            ansa8.Text = "Incorrect!!The correct answer is Freezing.";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ansa8.Text = "Incorrect!!The correct answer is Freezing.";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ansa8.Text = "Incorrect!!The correct answer is Freezing.";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ansa8.Text = "Correct!!";
        }

        private void next3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();  
            form1.Show();
            this.Hide();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            sciencepage1 scp1 = new sciencepage1();
            scp1.Show();
            this.Hide();
        }

        private void prev1_Load(object sender, EventArgs e)
        {

        }
    }
}
