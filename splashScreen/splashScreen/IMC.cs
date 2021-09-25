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
    public partial class IMC : Form
    {
        public IMC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double PESO, ALTURA, Resultado;



            if (double.TryParse(txtPESO.Text, out PESO) == false || double.TryParse(txtALTURA.Text, out ALTURA) == false)
            {
                MessageBox.Show("Por favor insira um peso e uma altura válidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtALTURA.Clear();
                txtPESO.Clear();
                txtPESO.Focus();
                return;
            };



            Resultado = PESO / (ALTURA * ALTURA);
            MessageBox.Show(Resultado.ToString(), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
