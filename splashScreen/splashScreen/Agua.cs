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
    public partial class Agua : Form
    {
        public Agua()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double PESO, agua_tomada, Resultado;

            if (double.TryParse(txtPESO.Text, out PESO) == false || double.TryParse(txtagua.Text, out agua_tomada) == false)
            {
                MessageBox.Show("Por favor insira um peso e quantidade tomada de água validos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtagua.Clear();
                txtPESO.Clear();
                txtPESO.Focus();
                return;
            };

            Resultado = 35 * PESO;


          if (Resultado > agua_tomada)
            {
                MessageBox.Show("Frequência diária insuficiente", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (Resultado == agua_tomada)
            {
                MessageBox.Show("Frequência Ideal", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Frequência Exessiva", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            MessageBox.Show(Resultado.ToString(), "Quantidade Ideal", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
