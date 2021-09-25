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
    public partial class Gordura : Form
    {
        public Gordura()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
			double imc, idade, sexo, Resultado;



			if (double.TryParse(txtIMC.Text, out imc) == false || double.TryParse(txtIDADE.Text, out idade) == false)
			{
				MessageBox.Show("Por favor insira um imc e altura válidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtIMC.Clear();
				txtIDADE.Clear();
				txtIMC.Focus();
				return;
			}


			if (radMASCULINO.Checked == false && radFEMININO.Checked == false)
			{
				MessageBox.Show("Por favor insira um sexo válido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

				return;
			}

			if (radMASCULINO.Checked == true)
			{
				sexo = 1;
			}


			else if (radFEMININO.Checked == true)
			{
				sexo = 0;

			}
            else
            {
				return;
            }

			Resultado = (1.20 * imc) + (0.23 * idade) - (10.8 * sexo) - 5.4;

			MessageBox.Show(Resultado.ToString(), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if(sexo == 1 && Resultado >= 16 && Resultado <= 20)
			{
				MessageBox.Show("Gordura Ideal", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			else if (sexo == 1 && Resultado <= 16)
            {
				MessageBox.Show("Gordura Insuficiente", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

            else
            {
				MessageBox.Show("Gordura Exessiva", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			if (sexo == 2 && Resultado >= 20 && Resultado <= 24)
			{
				MessageBox.Show("Gordura Ideal", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			else if (sexo == 2 && Resultado <= 20)
			{
				MessageBox.Show("Gordura Insuficiente", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			else
			{
				MessageBox.Show("Gordura Exessiva", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}










		}

        private void Gordura_Load(object sender, EventArgs e)
        {

        }
    }
}
