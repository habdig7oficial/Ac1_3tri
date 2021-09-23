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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                     
            pgbSplash.Value += 1;

            if (pgbSplash.Value >= 100)
            {
                //esconder o splash
                this.Hide();
                timer1.Enabled = false;//desliga o timer
                //Abrir o outro formulário
                MDI fTeste = new MDI();
                fTeste.Show();
            }
        }
    }
}
