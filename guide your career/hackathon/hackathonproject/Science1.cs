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
    public partial class Science1 : Form
    {
        public Science1()
        {
            InitializeComponent();
        }
        int phy, chem, math, com, total;

        private void txtmath_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            phy = int.Parse(textBox1.Text);
           chem = int.Parse(txtchem.Text);
            math= int.Parse(txtmath.Text);
           com = int.Parse(txtcom.Text);

            total=(phy+chem+math+com)*400/100;

            this.Hide();
            science2 science2 = new science2();
            science2.Show();
        }
    }
}
