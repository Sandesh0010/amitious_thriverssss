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
    public partial class sciencepage1 : Form
    {
        public sciencepage1()
        {
            InitializeComponent();
        }

        private void Q1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ansa1.Text = "Incorrect!!The correct answer is Sodium Carbonate.";
        }

        private void science1_Load(object sender, EventArgs e)
        {

        }

        private void sodiumcarbonate_Click(object sender, EventArgs e)
        {
            ansa1.Text = "Correct!!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ansa1.Text = "Incorrect!!The correct answer is Sodium Carbonate.";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ansa4.Text = "Incorrect!!The correct answer is Silver.";
        }

        private void camel_Click(object sender, EventArgs e)
        {
            ansa1.Text = "Incorrect!!The correct answer is Sodium Carbonate.";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ansa2.Text = "Incorrect!!The correct answer is 600:1.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ansa2.Text = "Incorrect!!The correct answer is 600:1.";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            ansa2.Text = "Incorrect!!The correct answer is 600:1.";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ansa2.Text = "Correct!!";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ansa3.Text = "Correct!!";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ansa3.Text = "Incorrect!!The correct answer is Pancrease.";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ansa3.Text = "Incorrect!!The correct answer is Pancrease.";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ansa3.Text = "Incorrect!!The correct answer is Pancrease.";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ansa4.Text = "Incorrect!!The correct answer is Silver.";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ansa4.Text = "Incorrect!!The correct answer is Silver.";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ansa4.Text = "Correct!!";
        }

        private void sciencepage2_Click(object sender, EventArgs e)
        {
            prev1 scp2 = new prev1();
            scp2.Show();
            this.Hide();
        }

        private void sprevious_Click(object sender, EventArgs e)
        {
            Quizcat quizcat = new Quizcat();
            quizcat.Show();
            this.Hide();
        }
    }
}
