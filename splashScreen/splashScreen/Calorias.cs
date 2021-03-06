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
    public partial class Calorias : Form
    {
        public Calorias()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
			double PESO, Resultado;

			if (double.TryParse(txtPESO.Text, out PESO) == false)
			{
				MessageBox.Show("Por favor insira um peso válido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtPESO.Clear();
				txtPESO.Focus();
				return;
			};

			if (radEmagecer.Checked == true)
			{
				Resultado = PESO * 25;

				MessageBox.Show("O Máximo de Calorias ingeridas deve ser:" + Resultado.ToString(), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);



			}

			else if (radManter.Checked == true)
			{
				Resultado = PESO * 30;

				MessageBox.Show("O Máximo de Calorias ingeridas deve ser:" + Resultado.ToString(), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);



			}

			else if (radEngoradar.Checked == true)
			{
				Resultado = PESO * 35;
				MessageBox.Show("O Máximo de Calorias ingeridas deve ser:" + Resultado.ToString(), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);



			}

			MessageBox.Show("Coma Alimentos com a Média de Carga Calorica Desejada \n  \n Por cada 1g de carboidratos: adicionar 4 calorias\n Por cada 1g de proteína: adicionar 4 calorias \n  Por cada 1g de gordura: adicionar 9 calorias.\n Assim você consiguira se alimentar bem e atingir seu objetivo" ,"Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);


		}
	}
}
