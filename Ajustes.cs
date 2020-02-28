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
    public partial class Ajustes : Form
    {
        private string rotor1, rotor2, rotor3, rotor4, rotor5;
        private EnigmaXD mf;
        private List<String> al1, al2, al3;
        //ToolTip ttSelect, ttDeselect, ttDown, ttUp;

        public Ajustes(EnigmaXD mf)
        {
            InitializeComponent();
            this.mf = mf;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ajustes_Load(object sender, EventArgs e)
        {
            al1 = new List<String>();
            al2 = new List<String>();
            al3 = new List<String>();
            al1.Add("Rotor I");
            al1.Add("Rotor II");
            al1.Add("Rotor III");
            al1.Add("Rotor IV");
            al1.Add("Rotor V");
            rotor1 = "EKMFLGDQVZNTOWYHXUSPAIBRCJ";
            rotor2 = "AJDKSIRUXBLHWTMCQGZNPYFVOE";
            rotor3 = "BDFHJLCPRTXVZNYEIWGAKMUSQO";
            rotor4 = "ESOVPZJAYQUIRHXLNFTGKDCMWB";
            rotor5 = "VZBRGITYUPSDNHLXAWMJQOFECK";
            al2.Add(rotor1);
            al2.Add(rotor2);
            al2.Add(rotor3);
            al2.Add(rotor4);
            al2.Add(rotor5);
            al3.Add("Q");
            al3.Add("E");
            al3.Add("V");
            al3.Add("J");
            al3.Add("Z");
            lstAvailableRotors.Items.Clear();
            for (int i = 0; i < al1.Count; i++)
            {
                lstAvailableRotors.Items.Add(al1[i]);
            }

            for (int i = 0; i < al2.Count; i++)
            {
                if (al2[i].ToString() == mf.GetLeftRotor())
                {
                    lstAvailableRotors.Items.Remove(al1[i].ToString());
                    lstSelectedRotors.Items.Add(al1[i].ToString());
                    break;
                }
            }

            for (int i = 0; i < al2.Count; i++)
            {
                if (al2[i].ToString() == mf.GetMiddleRotor())
                {
                    lstAvailableRotors.Items.Remove(al1[i].ToString());
                    lstSelectedRotors.Items.Add(al1[i].ToString());
                    break;
                }
            }
            for (int i = 0; i < al2.Count; i++)
            {
                if (al2[i].ToString() == mf.GetRightRotor())
                {
                    lstAvailableRotors.Items.Remove(al1[i].ToString());
                    lstSelectedRotors.Items.Add(al1[i].ToString());
                    break;
                }
            }

        }

        private void LstAvailableRotors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstAvailableRotors.SelectedIndex < 0)
            {
                return;
            }
            for (int i = 0; i < al1.Count; i++)
            {
                if (lstAvailableRotors.SelectedItem.ToString() == "" + al1[i])
                {
                    lblRotorStructure.Text = "" + al2[i];
                    return;
                }
            }
            lblRotorStructure.Text = "";
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            if (lstAvailableRotors.SelectedIndex < 0)
            {
                MessageBox.Show(this, "¡Seleccione un rotor primero!", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            lstSelectedRotors.Items.Add(lstAvailableRotors.SelectedItem);
            lstAvailableRotors.Items.Remove(lstAvailableRotors.SelectedItem);
            lblRotorStructure.Text = "";
        }

        private void BtnDeselect_Click(object sender, EventArgs e)
        {
            if (lstSelectedRotors.SelectedIndex < 0)
            {
                MessageBox.Show(this, "¡Seleccione un rotor primero!", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            lstAvailableRotors.Items.Add(lstSelectedRotors.SelectedItem);
            lstSelectedRotors.Items.Remove(lstSelectedRotors.SelectedItem);
        }

        private void BtnUp_Click(object sender, EventArgs e)
        {
            if (lstSelectedRotors.SelectedIndex <= 0)
            {
                return;
            }

            string strTemp = "" + lstSelectedRotors.Items[lstSelectedRotors.SelectedIndex - 1];
            lstSelectedRotors.Items[lstSelectedRotors.SelectedIndex - 1] = lstSelectedRotors.SelectedItem;
            lstSelectedRotors.Items[lstSelectedRotors.SelectedIndex] = strTemp;
            lstSelectedRotors.SelectedIndex = lstSelectedRotors.SelectedIndex - 1;
        }

        private void BtnDown_Click(object sender, EventArgs e)
        {
            if (lstSelectedRotors.SelectedIndex < 0 || lstSelectedRotors.SelectedIndex == lstSelectedRotors.Items.Count - 1)
            {
                return;
            }

            string strTemp = "" + lstSelectedRotors.Items[lstSelectedRotors.SelectedIndex + 1];
            lstSelectedRotors.Items[lstSelectedRotors.SelectedIndex + 1] = lstSelectedRotors.SelectedItem;
            lstSelectedRotors.Items[lstSelectedRotors.SelectedIndex] = strTemp;
            lstSelectedRotors.SelectedIndex = lstSelectedRotors.SelectedIndex + 1;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (lstSelectedRotors.Items.Count != 3)
            {
                MessageBox.Show(this, "¡Debes elegir exactamente tres rotores!", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            List<String> alRot = new List<String>();
            List<String> alRotName = new List<String>();
            List<String> alRotNotch = new List<String>();

            for (int j = 0; j < lstSelectedRotors.Items.Count; j++)
            {
                for (int i = 0; i < al1.Count; i++)
                {
                    if (lstSelectedRotors.Items[j].ToString() == "" + al1[i])
                    {
                        alRot.Add(al2[i]);
                        alRotName.Add(al1[i].ToString().Substring(al1[i].ToString().LastIndexOf(" ")).Trim());
                        alRotNotch.Add(al3[i]);
                        break;
                    }
                }
            }

            mf.ChangeRotors(alRot[0].ToString(),
                            alRotName[0].ToString(),
                            alRotNotch[0].ToString().ToCharArray()[0],
                            alRot[1].ToString(),
                            alRotName[1].ToString(),
                            alRotNotch[1].ToString().ToCharArray()[0],
                            alRot[2].ToString(),
                            alRotName[2].ToString(),
                            alRotNotch[2].ToString().ToCharArray()[0]);

            Close();
        }


    }
}
