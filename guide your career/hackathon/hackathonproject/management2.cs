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
    public partial class management2 : Form
    {
        public management2()
        {
            InitializeComponent();
        }
        int fin, ca;
        private void button1_Click(object sender, EventArgs e)
        {
            if(fin>ca)
            {
                DialogResult b = MessageBox.Show("We suggest you to join Finances and Economics related courses."+ "Press ok to see some institutions which provide finances related courses.", "suggestion",MessageBoxButtons.OK
            );
                if(b==DialogResult.OK)
                {
                    this.Hide();
                    Form10 form10 = new Form10();
                    form10.Show();
                }
            }
            else if(ca>fin)
            {
                DialogResult b = MessageBox.Show("We suggest you to try Computer related field."+ "Press ok to see some institutions which provide IT related courses.", "suggestion", MessageBoxButtons.OK);
                {
                    if (b == DialogResult.OK)
                    {
                        this.Hide();
                       BIT1 bIT = new BIT1();
                        bIT.Show();
                    }
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked) { ca++; }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox3.Checked) {
                ca++;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                fin++;
                ca++;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                fin++;
                ca++;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked) { fin++; }
        }
    }
}
