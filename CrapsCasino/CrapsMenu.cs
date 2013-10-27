using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrapsCasino
{
    public partial class CrapsMenu : Form
    {
        public CrapsMenu()
        {
            InitializeComponent();
        }
        private void btn_JugarVarios_Click(object sender, EventArgs e)
        {
            Jugadores JugadorVarios = new Jugadores();
            JugadorVarios.Show();
            this.Hide();
        }
    }
}
