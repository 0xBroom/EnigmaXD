using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnigmaXD
{
    class Rotor
    {
        private Label lbl;

        private char cIn = '\0';
        public string Layout { get; set; }
        internal Rotor Previous { get; set; }
        internal Rotor Next { get; set; }
        public byte Offset { get; set; }
        public char NotchPos { get; set; }

        public Rotor(string layout, Label lbl, char notchPos)
        {
            Layout = layout;
            this.lbl = lbl;
            NotchPos = notchPos;
            Offset = 0;

        }

        public char GetInverseCharAt(string ch)
        {
            int pos = Layout.IndexOf(ch);

            if (Offset > pos)
            {
                pos = 26 - (Offset - pos);
            }
            else
            {
                pos -= Offset;
            }

            if (Previous != null)
            {
                pos = (pos + Previous.Offset) % 26;
            }

            return (char)(65 + pos);
        }

        public void ResetOffset()
        {
            Offset = 0;
        }

        public bool HasNext()
        {
            return Next != null;
        }

        public bool HasPrevious()
        {
            return Previous != null;
        }

        public void Move()
        {
            if (Next == null)
            {
                return;
            }
            Offset++;
            if (Offset == 26)
            {
                Offset = 0;
                Next.Move();
            }

            lbl.Text = "" + ((char)(65 + Offset));
        }

        public void MoveBack()
        {
            if (Offset == 0)
            {
                Offset = 26;
            }
            Offset--;

            lbl.Text = "" + ((char)(65 + Offset));
        }

        public void PutDataIn(char s)
        {
            cIn = s;
            char c = s;
            c = (char)(((c - 65) + Offset) % 26 + 65);

            if (Next != null)
            {
                c = Layout.Substring((c - 65), 1).ToCharArray()[0];
                if ((((c - 65) + (-Offset)) % 26 + 65) >= 65)
                {
                    c = (char)(((c - 65) + (-Offset)) % 26 + 65);
                }
                else
                {
                    c = (char)(((c - 65) + (26 + (-Offset))) % 26 + 65);
                }
                Next.PutDataIn(c);

            }
        }

        public char GetDataOut()
        {
            char c = '\0';

            if (Next != null)
            {
                c = Next.GetDataOut();
                c = GetInverseCharAt("" + c);
            }
            else
            { //only in the reflector case
                c = Layout.Substring((cIn - 65), 1).ToCharArray()[0];
                c = (char)(((c - 65) + Previous.Offset) % 26 + 65);

            }

            return c;
        }

    }
}
