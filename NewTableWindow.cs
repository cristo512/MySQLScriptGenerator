using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySQLScriptGenerator
{
    public partial class NewTableWindow : Form
    {
        public NewTableWindow(ScriptWriter writer, string tableName)
        {
            InitializeComponent();

            this.value = new List<string>();
            this.type = new List<string>();

            this.writer = writer;
            this.tableName = tableName;

            TypeBox.Items.Add("int");
            TypeBox.Items.Add("varchar(32)");
            TypeBox.Items.Add("date");

            ValueNameBox.KeyPress += Utils.NormalizedName_KeyPress;
            ValueNameBox.TextChanged += Utils.NormalizedName_KeyChanged;

            it = 0;
            TypeBox.SelectedItem = TypeBox.Items[0];
        }

        List<string> value;
        List<string> type;

        int it;
        string tableName;
        ScriptWriter writer;



        private void FinishButton_Click(object sender, EventArgs e)
        {
            if (it == value.Count || (!string.IsNullOrEmpty(value.ElementAt(it).ToString())))
            {
                if (!String.IsNullOrEmpty(ValueNameBox.Text))
                {
                    value.Add(ValueNameBox.Text);

                    type.Add(TypeBox.Text.ToString());
                }

                writer.createTable(tableName, value, type);

                this.Close();
            }
            else
                MessageBox.Show("Wpisz dane.");
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if(it > 0)
            {
                if(it < value.Count)
                {
                    value[it] = ValueNameBox.Text;
                    type[it] = TypeBox.Text.ToString();
                }

                it--;

                ValueNameBox.Text = value.ElementAt(it).ToString();
                TypeBox.Text = type.ElementAt(it).ToString();

                if (it == 0)
                {
                    FinishButton.Visible = false;
                    BackButton.Visible = false;
                }
            }

        }
        private void NextButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ValueNameBox.Text))
                MessageBox.Show("Wpisz dane.");
            else
            {
                if(value.Count == it)
                {
                    value.Add(ValueNameBox.Text);
                    type.Add(TypeBox.Text.ToString());

                    ValueNameBox.Clear();
                }
                else
                {
                    value[it] = ValueNameBox.Text;
                    type[it] = TypeBox.Text.ToString();

                    if (value.Count == it + 1)
                        ValueNameBox.Clear();
                    else
                    {
                        ValueNameBox.Text = value.ElementAt(it + 1).ToString();
                        TypeBox.Text = type.ElementAt(it + 1).ToString();
                    }
                }

                FinishButton.Visible = true;
                BackButton.Visible = true;
                it++;
            }
        }

        private void TypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }



    }
}
