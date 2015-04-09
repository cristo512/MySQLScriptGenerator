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
    public partial class ChoiceWindow : Form
    {
        public ChoiceWindow(ScriptWriter writer, string tableName)
        {
            InitializeComponent();

            this.value = new List<string>();
            this.type = new List<string>();

            this.writer = writer;
            this.tableName = tableName;

            TypeBox.Items.Add("int");
            TypeBox.Items.Add("varchar(32)");
            TypeBox.Items.Add("date");
        }

        private List<string> value;
        private List<string> type;
        private string tableName;
        public ScriptWriter writer;



        private void FinishButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Value: " + value.ElementAt(0) + " Type: " + type.ElementAt(0));

            switch (writer.createTable(tableName, value, type))
            {
                case 1:
                    MessageBox.Show("Brak używanej bazy.");
                    break;
                case 2:
                    MessageBox.Show("Podaj nazwę tabeli.");
                    break;
                case 3:
                    MessageBox.Show("Składnia jest niepoprawna.");
                    break;
                case 4:
                    MessageBox.Show("Tabela o tej nazwie już istnieje.");
                    break;
            }

            this.Close();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (ValueNameBox.Text == "")
                MessageBox.Show("Wpisz dane.");
            else
            {
                value.Add(ValueNameBox.Text);
                type.Add(TypeBox.SelectedItem.ToString());
                FinishButton.Visible = true;
                BackButton.Visible = true;
                ValueNameBox.Clear();
                TypeBox.SelectedItem = 0;
            }
        }

        private void ValueNameBox_MaskInputRejected(object sender, System.Windows.Forms.MaskInputRejectedEventArgs e)
        {

        }

        private void TypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
