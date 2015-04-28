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
            if (!((char.IsControl(c)) || char.IsLetterOrDigit(c) || c == '_'))
                return false;

            return true;
        }

        static public bool validateText(string text)
        {
            bool allDigits = true;
            for(int i = 0; i < text.Length; i++)
            {
                if(!char.IsDigit(text[i]))
                    allDigits = false;

                if (!isCharacterAcceptable(text[i]))
                    return false;
            }

            return !allDigits;
        }

        static public void NormalizedName_KeyChanged(object sender, EventArgs e)
        {
            MaskedTextBox textbox = sender as MaskedTextBox;

            if (textbox != null)
            {
                List<char> list = new List<char>();

                for (int i = 0; i < textbox.Text.Length; i++)
                {
                    KeyPressEventArgs arg = new KeyPressEventArgs(textbox.Text[i]);
                    NormalizedName_KeyPress(sender, arg);
                    if (!arg.Handled)
                        list.Add(textbox.Text[i]);
                }
            }
        }

        static public void NormalizedName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = false;

            if (hehe)
            {
                MaskedTextBox textbox = sender as MaskedTextBox;

                if (textbox.Text.Length != glupi.Length)
                    e.KeyChar = glupi[textbox.Text.Length];
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
        static public bool hehe = false;
    }
}
