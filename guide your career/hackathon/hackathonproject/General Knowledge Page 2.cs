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
    public partial class General_Knowledge_Page_2 : Form
    {
        public General_Knowledge_Page_2()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ans6.Text = "Incorrect!!The correct answer is Mount Everest.";
        }

        private void General_Knowledge_Page_2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ans5.Text = "Correct!!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ans5.Text = "Incorrect!!The correct answer is William Shakespeare.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ans5.Text = "Incorrect!!The correct answer is William Shakespeare.";
        }

        private void camel_Click(object sender, EventArgs e)
        {
            ans5.Text = "Incorrect!!The correct answer is William Shakespeare.";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ans6.Text = "Incorrect!!The correct answer is Mount Everest.";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ans6.Text = "Correct!!";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ans6.Text = "Incorrect!!The correct answer is Mount Everest.";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ans7.Text = "Incorrect!!The correct answer is skin.";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ans7.Text = "Incorrect!!The correct answer is skin.";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ans7.Text = "Incorrect!!The correct answer is skin.";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ans7.Text = "Correct!!";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            ans8.Text = "Correct!!";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ans8.Text = "Incorrect!!The correct answer is Asia.";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ans8.Text = "Incorrect!!The correct answer is Asia.";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ans8.Text = "Incorrect!!The correct answer is Asia.";
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void Next2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show(); 
            this.Hide();
        }
    }
}
