using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnigmaXD
{
    public partial class EnigmaXD : Form
    {
        private Rotor rr, rm, rl, reflector;


        public EnigmaXD()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Inicia todos los componentes de la aplicación.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnigmaXD_Load(object sender, EventArgs e)
        {
            rr = new Rotor("BDFHJLCPRTXVZNYEIWGAKMUSQO", lblRotor1, 'V');
            rm = new Rotor("AJDKSIRUXBLHWTMCQGZNPYFVOE", lblRotor2, 'E');
            rl = new Rotor("EKMFLGDQVZNTOWYHXUSPAIBRCJ", lblRotor3, 'Q');
            reflector = new Rotor("YRUHQSLDPXNGOKMIEBFZCWVJAT", null, '\0');

            //J,Z

            rr.Next = rm;
            rm.Next = rl;
            rl.Next = reflector;
            rm.Previous = rr;
            rl.Previous = rm;
            reflector.Previous = rl;
        }


        /// <summary>
        /// Abre la página acerca de.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAbout_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        /// <summary>
        /// Abre la pantalla de configuración de los rotores y el reflector.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSettings_Click(object sender, EventArgs e)
        {
            Ajustes ajustes = new Ajustes(this);
            ajustes.Show();
        }

        /// <summary>
        /// Mueve el rotor de la derecha una posición hacia adelante.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRotor1Up_Click(object sender, EventArgs e)
        {
            rr.Move();
        }

        /// <summary>
        /// Mueve el rotor de la derecha una posición hacia atrás.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRotor1Down_Click(object sender, EventArgs e)
        {
            rr.MoveBack();
        }

        /// <summary>
        /// Mueve el rotor del centro una posición hacia adelante.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRotor2Up_Click(object sender, EventArgs e)
        {
            rm.Move();
        }

        /// <summary>
        /// Mueve el rotor del centro una posición hacia atrás.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRotor2Down_Click(object sender, EventArgs e)
        {
            rm.MoveBack();
        }

        /// <summary>
        /// Mueve el rotor de la izquierda una posición hacia adelante.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRotor3Up_Click(object sender, EventArgs e)
        {
            rl.Move();
        }

        /// <summary>
        /// Mueve el rotor de la izquierda una posición hacia atrás.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRotor3Down_Click(object sender, EventArgs e)
        {
            rl.MoveBack();
        }

        /// <summary>
        /// Recorre la cadena de texto introducida y la pasa los caracteres por los rotores
        /// para encriptarlos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Enc_decBtn_Click(object sender, EventArgs e)
        {
            char[] chIn = txtInit.Text.ToUpper().ToCharArray(); //Pasamos a mayúscula.
            txtFinal.Text = "";
            for (int i = 0; i < chIn.Length; i++)
            {
                if (chIn[i] >= 65 && chIn[i] <= 90)
                {
                    rr.Move();
                    rr.PutDataIn(chIn[i]);//Damos la entrada.
                    txtFinal.AppendText("" + rr.GetDataOut());//ponemos la salida en el otro lado.
                }
            }
        }

        /// <summary>
        /// Cambia la configuración del reflector en el programa actual.
        /// </summary>
        /// <param name="refl"> Nueva configuración de reflector </param>
        public void SetReflector(string refl)
        {
            reflector = new Rotor(refl, null, '\0');
            reflector.Previous = rl;
            rl.Next = reflector;
        }

        /// <summary>
        /// Devuelve el reflector.
        /// </summary>
        /// <returns>{string} Reflector</returns>
        public string GetReflector()
        {
            return reflector.Layout;
        }

        /// <summary>
        /// Devuelve el rotor derecho.
        /// </summary>
        /// <returns>{string} rm</returns>
        public string GetRightRotor()
        {
            return rr.Layout;
        }

        /// <summary>
        /// Devuelve el rotor del medio.
        /// </summary>
        /// <returns>{string} rm</returns>
        public string GetMiddleRotor()
        {
            return rm.Layout;
        }

        /// <summary>
        /// Devuelve el rotor de izquierdo.
        /// </summary>
        /// <returns>{string} rl</returns>
        public string GetLeftRotor()
        {
            return rl.Layout;
        }

        public void ChangeRotors(string rot1, string rotName1, char rotNotch1,
                                 string rot2, string rotName2, char rotNotch2,
                                 string rot3, string rotName3, char rotNotch3)
        {
            lblRotorS.Text = rotName1;
            lblRotorM.Text = rotName2;
            lblRotorD.Text = rotName3;
            rr = null;
            rm = null;
            rl = null;

            rr = new Rotor(rot3, lblRotor1, rotNotch3);
            rm = new Rotor(rot2, lblRotor2, rotNotch2);
            rl = new Rotor(rot1, lblRotor3, rotNotch1);

            rr.ResetOffset();
            rm.ResetOffset();
            rl.ResetOffset();

            rr.Next = rm;
            rm.Next = rl;
            rl.Next = reflector;

            rm.Previous = rr;
            rl.Previous = rm;
            reflector.Previous = rl;

            lblRotor1.Text = "A";
            lblRotor2.Text = "A";
            lblRotor3.Text = "A";
        }
    }
}
