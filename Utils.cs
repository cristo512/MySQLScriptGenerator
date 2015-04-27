using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySQLScriptGenerator
{
    static class Utils
    {
        static public bool isCharacterAcceptable(char c)
        {
            if (!((char.IsControl(c)) || char.IsLetter(c)))
                return false;

            return true;
        }

        static public void validateText(string text)
        {
            text.Trim();
            text.Replace(' ', '_');
        }

        static public void NormalizedName_KeyChanged(object sender, EventArgs e)
        {
            MaskedTextBox textbox = sender as MaskedTextBox;
            char[] text = textbox.Text.ToCharArray();

            if (textbox != null)
            {
                textbox.Text.Replace(' ', '_');
            }
        }

        static public void NormalizedName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = false;

            if (hehe)
            {
                if (it != glupi.Length)
                    e.KeyChar = glupi[it++];
                else
                    e.Handled = true;

            }
            else if (e.KeyChar == ' ')
            {
                e.KeyChar = '_';
            }
            else if (!isCharacterAcceptable(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        static string glupi = "Jestem gejem ";
        static int it = 0;
        static public bool hehe = false;
    }
}
