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
    public partial class Jugadores : Form
    {
        Participante participante1;
        Participante participante2;
        Participante participante3;
        List<Participante> ListaParticipantes = new List<Participante>();
        public Jugadores()
        {
            InitializeComponent();
            participante1 = new Participante();
            participante2 = new Participante();
            participante3 = new Participante();

        }

        private void btn_Jugar_Click(object sender, EventArgs e)
        {
            participante1.nombre = txt_Jugador1.Text;
            participante1.totaldinero = Convert.ToDouble(txt_apuestaJugador1.Text);
            participante1.turno = 1;

           
            participante2.nombre = txt_Jugador2.Text;
            participante2.totaldinero = Convert.ToDouble(txt_apuestaJugador2.Text);
            participante2.turno = 2;

            participante3.nombre = txt_Jugador3.Text;
            participante3.totaldinero = Convert.ToDouble(txt_apuestaJugador3.Text);
            participante3.turno = 3;
            this.Close();
            Form1 jugadores = new Form1(participante1,participante2,participante3);
            jugadores.Show();
        }
    }
}
