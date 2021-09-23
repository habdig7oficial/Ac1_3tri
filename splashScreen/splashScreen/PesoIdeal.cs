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
    public partial class PesoIdeal : Form
    {
        public PesoIdeal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double altura, peso, peso_atual;

            if (double.TryParse(txtAltura.Text.Replace(".", ","), out altura) == false || double.TryParse(pa.Text.Replace(".", ","), out peso_atual) == false)
            {
                MessageBox.Show("Digite uma altura válida", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAltura.Clear();
                txtAltura.Focus();
                return;
            }

            if (altura >= 2.72)
            {
                MessageBox.Show("Digite uma altura válida", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAltura.Clear();
                txtAltura.Focus();
                return;
            }

            if (rdbFem.Checked == true)
            {
                peso = 62.1 * altura - 44.7;
            }
            else
            {
                peso = 72.7 * altura - 58;
            }
            MessageBox.Show("Seu peso ideal: " + peso.ToString());

            if (peso == peso_atual)
            {
                MessageBox.Show("Você está no peso ideal", "Peso Ideal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            else if (peso > peso_atual)
            {
                MessageBox.Show("Você poderia engoradar um pouco...", "Peso Negativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (peso < peso_atual){
                MessageBox.Show("Você poderia emagrecer um pouco...", "Peso Positivo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }


        }
    }
}
