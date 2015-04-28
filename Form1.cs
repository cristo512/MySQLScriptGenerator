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
        public ScriptWriter writer = null;
		
        public MainWindow()
        {
            InitializeComponent();
            databaseName.KeyPress += Utils.NormalizedName_KeyPress;
            databaseName.TextChanged += Utils.NormalizedName_KeyChanged;

            tableName.KeyPress += Utils.NormalizedName_KeyPress;
            tableName.TextChanged += Utils.NormalizedName_KeyChanged;

            Random rnd = new Random();
            if (rnd.Next(1) == 0)
                Utils.hehe = true;
            writer = new ScriptWriter();
        }

        private void CreateDatabaseButton_Click(object sender, EventArgs e)
        {
            if (!Utils.validateText(databaseName.Text))
            {
                MessageBox.Show("Nieprawidłowa nazwa");
                return;
            }

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
            CreateTableError error;
            if (!writer.canCreateTable(tableName.Text, out error))
            {
                switch (error)
                {
                    case CreateTableError.NoDatabase:
                        MessageBox.Show("Brak używanej bazy.");
                        break;
                    case CreateTableError.StringIsEmpty:
                        MessageBox.Show("Podaj nazwę tabeli.");
                        break;
                    case CreateTableError.TableExsists:
                        MessageBox.Show("Tabela o tej nazwie już istnieje.");
                        break;
                }
            }
            else
            {
                Form tmp = new NewTableWindow(writer, tableName.Text);

                tmp.Show();
            }

            tableName.Clear();
        }

        private void AddRecordButton_Click(object sender, EventArgs e)
        {

            //List<string> value;
            //value = new List<string>();

            //for (int i = 0; i < 5; i++)
            //{
            //    value.Add((i + 1).ToString());
            //    value.Add("Paweł");
            //    int result = writer.addRecord("Tabela", value);

            //    switch (result)
            //    {
            //        case 1:
            //            MessageBox.Show("Brak używanej bazy.");
            //            value.Clear();
            //            break;
            //        case 2:
            //            MessageBox.Show("Dane tablicy się nie zgadzają.");
            //            value.Clear();
            //            break;
            //    }

            //}
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

        private void button1_Click(object sender, EventArgs e)
        {

        }



    }
}
