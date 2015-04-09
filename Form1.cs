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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            
            writer = new ScriptWriter();
        }

        private void CreateDatabaseButton_Click(object sender, EventArgs e)
        {
            if(databaseName.Text == "")
                MessageBox.Show("Podaj nazwę bazy.");
            else if(!writer.createDatabase(databaseName.Text))
                MessageBox.Show("Baza o tej nazwie już istnieje.");
            else
            {
                useDatabaseComboBox.Items.Add(databaseName.Text);
                if (useDatabaseCheckBox.Checked)
                    useDatabaseComboBox.SelectedItem = databaseName.Text;
                if (writer.usingDatabase == 0)
                    useDatabaseCheckBox.Checked = true;
                else
                    useDatabaseCheckBox.Checked = false;
            }

            databaseName.Clear();
        }

        private void CreateTableButton_Click(object sender, EventArgs e)
        {
            List<string> value;
            List<string> type;

            value = new List<string>();
            type = new List<string>();

            value.Add("id");
            type.Add("int");
            value.Add("Imie");
            type.Add("char(32)");

            switch (writer.createTable(tableName.Text, value, type))
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

            tableName.Clear();
        }

        private void AddRecordButton_Click(object sender, EventArgs e)
        {
            List<string> value;
            value = new List<string>();

            for (int i = 0; i < 5; i++)
            {
                value.Add((i + 1).ToString());
                value.Add("Paweł");
		int result = writer.addRecord("Tabela", value);

                switch (result)
                {
                    case 1:
                        MessageBox.Show("Brak używanej bazy.");
                        value.Clear();
                        break;
                    case 2:
                        MessageBox.Show("Dane tablicy się nie zgadzają.");
                        value.Clear();
                        break;
                }

            }
        }
        private void Form1_Load(object sender, System.EventArgs e)
        {

        }

        private void label1_Click_1(object sender, System.EventArgs e)
        {

        }

        private void label1_Click(object sender, System.EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
        {

        }
        private void maskedTextBox1_MaskInputRejected(object sender, System.Windows.Forms.MaskInputRejectedEventArgs e)
        {

        }

        private void useDatabaseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!writer.setUsingDatabase(useDatabaseComboBox.SelectedItem.ToString()))
                MessageBox.Show("Z nieznanych mi powodów nie udało się dodać bazy.");
        }

        ScriptWriter writer = null;

        private void button1_Click(object sender, EventArgs e)
        {
            Form tmp = new Form();
            tmp.Width = 750;
            System.Windows.Forms.Button BackButton;
            System.Windows.Forms.Button NextButton;
            System.Windows.Forms.Button EndButton;

            System.Windows.Forms.MaskedTextBox ValueBox;
            System.Windows.Forms.ComboBox TypeBox;
            
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;

            List<string> value;
            List<string> type;

            value = new List<string>();
            type = new List<string>();


            tmp.Show();
        }

    }
}
