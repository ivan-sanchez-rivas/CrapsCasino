using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CrapsCasino
{
    public partial class Form1 : Form
    {
        
        CrapsJuego craps = new CrapsJuego();
        CrapsJuego.Estado estado = CrapsJuego.Estado.CONTINUAR;
        Participante participante1 = new Participante();
        Participante participante2 = new Participante();
        Participante participante3 = new Participante();
        Random r = new Random();
        string path = Application.StartupPath;
        int Punto = 0;
        int contador = 0;
        int contador2 = 0;
        int resultado = 0;
        int sumaDados;
        int turno = 1;
        double montoTotal, totalGanado;

        public Form1(Participante participanteJugador1, Participante participanteJugador2, Participante participanteJugador3)
        {
            InitializeComponent();
            participante1 = participanteJugador1;
            participante2 = participanteJugador2;
            participante3 = participanteJugador3;
            participante1.turno = 1;
            participante2.turno = 2;
            participante3.turno = 3;


        } 
        private void button1_Click(object sender, EventArgs e)
        {
            int dado1 = r.Next(1, 7);
            int dado2 = r.Next(1, 7);
            try
            {
                timer1.Start();
                timer2.Start();
                contador = contador + 1;
                if (contador > 25)
                {
                    contador = 0;
                    timer1.Stop();

                }

                contador2 = contador2 + 1;
                if (contador2 > 25)
                {
                    contador2 = 0;
                    timer2.Stop();
                }

                if (contador < 25)
                {
                    if (dado1 == 1)
                    {
                        dado1 = 1;
                        pbx_p1.Image = Image.FromFile(path + "\\Imagenes\\dice1.png");
                    }
                    else if (dado1 == 2)
                    {
                        dado1 = 2;
                        pbx_p1.Image = Image.FromFile(path + "\\Imagenes\\dice2.png");
                    }
                    else if (dado1 == 3)
                    {
                        dado1 = 3;
                        pbx_p1.Image = Image.FromFile(path + "\\Imagenes\\dice3.png");
                    }
                    else if (dado1 == 4)
                    {
                        dado1 = 4;
                        pbx_p1.Image = Image.FromFile(path + "\\Imagenes\\dice4.png");
                    }
                    else if (dado1 == 5)
                    {
                        dado1 = 5;
                        pbx_p1.Image = Image.FromFile(path + "\\Imagenes\\dice5.png");
                    }
                    else if (dado1 == 6)
                    {
                        dado1 = 6;
                        pbx_p1.Image = Image.FromFile(path + "\\Imagenes\\dice6.png");
                    }
                }

                if (contador2 < 15)
                {
                    if (dado2 == 1)
                    {
                        dado2 = 1;
                        pbx_p2.Image = Image.FromFile(path + "\\Imagenes\\dice1.png");

                    }
                    else if (dado2 == 2)
                    {
                        dado2 = 2;
                        pbx_p2.Image = Image.FromFile(path + "\\Imagenes\\dice2.png");

                    }
                    else if (dado2 == 3)
                    {
                        dado2 = 3;
                        pbx_p2.Image = Image.FromFile(path + "\\Imagenes\\dice3.png");

                    }
                    else if (dado2 == 4)
                    {
                        dado2 = 4;
                        pbx_p2.Image = Image.FromFile(path + "\\Imagenes\\dice4.png");

                    }
                    else if (dado2 == 5)
                    {
                        dado2 = 5;
                        pbx_p2.Image = Image.FromFile(path + "\\Imagenes\\dice5.png");

                    }
                    else if (dado2 == 6)
                    {
                        dado2 = 6;
                        pbx_p2.Image = Image.FromFile(path + "\\Imagenes\\dice6.png");
                    }
                }
                if (contador == 0 && contador == 0)
                {
                    resultado = dado1 + dado2;
                    lbl_resultado.Text = resultado.ToString();
                    sumaDados = resultado;
                    switch ((CrapsJuego.NombreDados)sumaDados)
                    {
                        case CrapsJuego.NombreDados.SEVEN:
                        case CrapsJuego.NombreDados.YO_LEVEN:
                            estado = CrapsJuego.Estado.GANAR;
                            if (participante1.turno == turno)
                            {
                                totalGanado = montoTotal * 2;
                                participante1.totaldinero = totalGanado + participante1.totaldinero;
                                lbl_totaldineroJugador1.Text = participante1.totaldinero.ToString();

                                //if (txt_Apuestajugador2.Text != "0" && txt_apuestaJugador3.Text == "0")
                                //{
                                //    participante2.totaldinero = participante2.totaldinero - participante2.apuesta;
                                //    lbl_totaldineroJugador2.Text = participante2.totaldinero.ToString();
                                //}
                                //else if (txt_Apuestajugador2.Text == "0" && txt_apuestaJugador3.Text != "0")
                                //{
                                //    participante3.totaldinero = participante3.totaldinero - participante3.apuesta;
                                //    lbl_totaldineroJugador3.Text = participante3.totaldinero.ToString();
                                //}
                                //else
                                //{
                                //    participante2.totaldinero = participante2.totaldinero - participante2.apuesta;
                                //    lbl_totaldineroJugador2.Text = participante2.totaldinero.ToString();

                                //    participante3.totaldinero = participante3.totaldinero - participante3.apuesta;
                                //    lbl_totaldineroJugador3.Text = participante3.totaldinero.ToString();
                                //}
                            }
                            else if (participante2.turno == turno)
                            {
                                totalGanado = montoTotal * 2;
                                participante2.totaldinero = totalGanado + participante2.totaldinero;
                                lbl_totaldineroJugador2.Text = participante2.totaldinero.ToString();
                            }
                            else
                            {
                                totalGanado = montoTotal * 2;
                                participante3.totaldinero = totalGanado + participante3.totaldinero;
                                lbl_totaldineroJugador3.Text = participante3.totaldinero.ToString();
                            }
                            lbl_monto.Text = "0";
                            montoTotal = 0;
                            MessageBox.Show("Ganaste!");
                            
                            break;

                        case CrapsJuego.NombreDados.SNAKE_EYES:
                        case CrapsJuego.NombreDados.TREY:
                        case CrapsJuego.NombreDados.BOX_CARS:
                            estado = CrapsJuego.Estado.PERDIO;
                            MessageBox.Show("Perdiste");
                            
                            if (turno > 3)
                            {
                                turno = 1;
                            }
                            if (participante1.turno == turno)
                            {
                                lbl_turno.Text = participante1.nombre;
                                if (txt_Apuestajugador2.Text != "0" && txt_apuestaJugador3.Text == "0")
                                {
                                    participante2.totaldinero = participante2.totaldinero + (2 * participante2.apuesta);
                                    lbl_totaldineroJugador2.Text = participante2.totaldinero.ToString();
                                }
                                else if (txt_Apuestajugador2.Text == "0" && txt_apuestaJugador3.Text != "0")
                                {
                                    participante3.totaldinero = participante3.totaldinero + (2 * participante3.apuesta);
                                    lbl_totaldineroJugador3.Text = participante3.totaldinero.ToString();
                                }
                                else
                                {
                                    participante2.totaldinero = participante2.totaldinero + (2 * participante2.apuesta);
                                    lbl_totaldineroJugador2.Text = participante2.totaldinero.ToString();

                                    participante3.totaldinero = participante3.totaldinero + (2 * participante3.apuesta);
                                    lbl_totaldineroJugador3.Text = participante3.totaldinero.ToString();
                                }

                            }
                            else if (participante2.turno == turno)
                            {
                                lbl_turno.Text = participante2.nombre;
                                if (txt_apuestaJugador1.Text != "0" && txt_apuestaJugador3.Text == "0")
                                {
                                    participante1.totaldinero = participante1.totaldinero + (2 * participante1.apuesta);
                                    lbl_totaldineroJugador1.Text = participante1.totaldinero.ToString();
                                }
                                else if (txt_apuestaJugador1.Text == "0" && txt_apuestaJugador3.Text != "0")
                                {
                                    participante3.totaldinero = participante3.totaldinero + (2 * participante3.apuesta);
                                    lbl_totaldineroJugador3.Text = participante3.totaldinero.ToString();
                                }
                                else
                                {
                                    participante1.totaldinero = participante1.totaldinero + (2 * participante1.apuesta);
                                    lbl_totaldineroJugador1.Text = participante1.totaldinero.ToString();

                                    participante3.totaldinero = participante3.totaldinero + (2 * participante3.apuesta);
                                    lbl_totaldineroJugador3.Text = participante3.totaldinero.ToString();
                                }

                            }
                            else
                            {
                                lbl_turno.Text = participante3.nombre;
                                if (txt_apuestaJugador1.Text != "0" && txt_Apuestajugador2.Text == "0")
                                {
                                    participante1.totaldinero = participante1.totaldinero + (2 * participante1.apuesta);
                                    lbl_totaldineroJugador1.Text = participante1.totaldinero.ToString();
                                }
                                else if (txt_apuestaJugador1.Text == "0" && txt_Apuestajugador2.Text != "0")
                                {
                                    participante2.totaldinero = participante2.totaldinero + (2 * participante2.apuesta);
                                    lbl_totaldineroJugador2.Text = participante2.totaldinero.ToString();
                                }
                                else
                                {
                                    participante1.totaldinero = participante1.totaldinero + (2 * participante1.apuesta);
                                    lbl_totaldineroJugador1.Text = participante1.totaldinero.ToString();

                                    participante2.totaldinero = participante2.totaldinero + (2 * participante2.apuesta);
                                    lbl_totaldineroJugador2.Text = participante2.totaldinero.ToString();
                                }

                            }
                            turno++;
                            break;
                        default:
                            estado = CrapsJuego.Estado.CONTINUAR;
                            MessageBox.Show("Continuar");
                            Punto = sumaDados;
                            break;
                    }
                }
               

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error", "Error");
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {

                button1_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error", "Error");
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                button1_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error", "Error");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_NomJugador1.Text = participante1.nombre;
            lbl_totaldineroJugador1.Text = participante1.totaldinero.ToString();

            lbl_NomJugador2.Text = participante2.nombre;
            lbl_totaldineroJugador2.Text = participante2.totaldinero.ToString();

            lbl_NomJugador3.Text = participante3.nombre;
            lbl_totaldineroJugador3.Text = participante3.totaldinero.ToString();

            if (participante1.turno == turno)
            {
                lbl_turno.Text = participante1.nombre;
            }
            else if (participante2.turno == turno)
            {
                lbl_turno.Text = participante2.nombre;
            }
            else
            {
                lbl_turno.Text = participante3.nombre;
            }

        }
        private void btn_apostar_Click(object sender, EventArgs e)
        {
            participante1.apuesta = Convert.ToDouble(txt_apuestaJugador1.Text);
            double total = participante1.totaldinero - participante1.apuesta;
            participante1.totaldinero = total;

            participante2.apuesta = Convert.ToDouble(txt_Apuestajugador2.Text);
            double total2 = participante2.totaldinero - participante2.apuesta;
            participante2.totaldinero = total2;

            participante3.apuesta = Convert.ToDouble(txt_apuestaJugador3.Text);
            double total3 = participante3.totaldinero - participante3.apuesta;
            participante3.totaldinero = total3;

            lbl_totaldineroJugador1.Text = participante1.totaldinero.ToString();
            lbl_totaldineroJugador2.Text = participante2.totaldinero.ToString();
            lbl_totaldineroJugador3.Text = participante3.totaldinero.ToString();

            montoTotal = participante1.apuesta + participante2.apuesta + participante3.apuesta;
            lbl_monto.Text = montoTotal.ToString();


        }

    }
}
