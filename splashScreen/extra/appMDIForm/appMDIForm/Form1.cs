using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appMDIForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exercício1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEx1 f1 = new frmEx1();
            f1.MdiParent = this;
            f1.Show();

        }

        private void exercício2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEx2 f2 = new frmEx2();
            f2.MdiParent = this;
            f2.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
