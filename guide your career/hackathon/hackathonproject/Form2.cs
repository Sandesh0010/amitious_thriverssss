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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void camel_Click(object sender, EventArgs e)
        {
            ans1.Text = "correct!!";
        }

        private void ans1_Click(object sender, EventArgs e)
        {

        }

        private void horse_Click(object sender, EventArgs e)
        {
            ans1.Text = "Incorrect!! The correct answer is Camel.";
        }

        private void donkey_Click(object sender, EventArgs e)
        {
            ans1.Text = "Incorrect!! The correct answer is Camel.";
        }

        private void Zebra_Click(object sender, EventArgs e)
        {
            ans1.Text = "Incorrect!! The correct answer is Camel.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ans2.Text = "Incorrect!! The correct answer is Mars.";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ans2.Text = "Correct Answer!!";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ans2.Text = "Incorrect!! The correct answer is Mars.";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ans2.Text = "Incorrect!! The correct answer is Mars.";
        }

        private void Next_Click(object sender, EventArgs e)
        {
            General_Knowledge_Page_2 gk2 = new General_Knowledge_Page_2();
            gk2.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ans3.Text = "Incorrect!! The correct answer is Leonardo Da Vinci.";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ans3.Text = "Incorrect!! The correct answer is Leonardo Da Vinci.";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ans3.Text = "Correct Answer!!";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ans3.Text = "Incorrect!! The correct answer is Leonardo Da Vinci.";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ans4.Text = "Incorrect!! The correct answer is Yen.";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ans4.Text = "Incorrect!! The correct answer is Yen.";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ans4.Text = "Incorrect!! The correct answer is Yen.";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ans4.Text = "Correct!!";
        }
    }
}
