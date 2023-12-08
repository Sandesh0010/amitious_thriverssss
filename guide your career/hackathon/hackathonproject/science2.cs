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
    public partial class science2 : Form
    {
        public science2()
        {
            InitializeComponent();
        }
        int it = 0, ca = 0;

        private void ck2_CheckedChanged(object sender, EventArgs e)
        {
            if (ck2.Checked) { ca++; }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox3.Checked) { it++; }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked) {  it++;
                ca++;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked) {  it++;
                ca++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(it>ca)
            {
                DialogResult a= MessageBox.Show("We suggest you to try Computer related Streams "+ "Press ok to see some institutions which provide IT related courses.  ", "suggestion",MessageBoxButtons.OK);
                if(a == DialogResult.OK)
                {
                    this.Hide();
                    BIT1 bIT1 = new BIT1();
                    bIT1.Show();
                }
   
            }
            else if(ca>it)
            {
                DialogResult a = MessageBox.Show("We suggest you to try Finances and Economics related streams."+"Press ok to see some institutions which provide finances related courses.  ", "suggestion", MessageBoxButtons.OK);
                if (a == DialogResult.OK)
                {
                    this.Hide();
                   Form10 form10 = new Form10();
                    form10.Show();
                }
            }
    
            
            }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked) { it++; }
        }
       
    }
}
