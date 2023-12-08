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
    public partial class management1 : Form
    {
        public management1()
        {
            InitializeComponent();
        }
        int fin, eco, comm, mathm,total;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void management1_Load(object sender, EventArgs e)
        {

        }

        private void btnqns1next_Click(object sender, EventArgs e)
        {
            fin = int.Parse(txtfinances.Text);
            eco = int.Parse(txteco.Text);
            comm= int.Parse(txtcomm.Text);
            mathm = int.Parse(txtmathm.Text);
            total = (fin + eco + comm + mathm) * 400 / 100;
            this.Hide();
            management2 management2 = new management2();
            management2.Show();
        }
    }
}
