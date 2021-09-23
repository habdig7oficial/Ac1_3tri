using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace splashScreen
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void frmTeste_Load(object sender, EventArgs e)
        {
            //Aparcer a data:
            lblData.Text = DateTime.Now.ToLongDateString();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Aparecer a hora:
            lblHora.Text = DateTime.Now.ToShortTimeString();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iMCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IMC imc = new IMC();
            imc.MdiParent = this;
            imc.Show();
        }

        private void pesoIdealToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PesoIdeal peso = new PesoIdeal();
            peso.MdiParent = this;
            peso.Show();
        }
    }
}
