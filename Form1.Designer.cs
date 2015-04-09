namespace MySQLScriptGenerator
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CreateDatabaseButton = new System.Windows.Forms.Button();
            this.CreateTableButton = new System.Windows.Forms.Button();
            this.AddRecordButton = new System.Windows.Forms.Button();
            this.tableName = new System.Windows.Forms.MaskedTextBox();
            this.databaseName = new System.Windows.Forms.MaskedTextBox();
            this.useDatabaseCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.useDatabaseComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateDatabaseButton
            // 
            this.CreateDatabaseButton.Location = new System.Drawing.Point(49, 114);
            this.CreateDatabaseButton.Name = "CreateDatabaseButton";
            this.CreateDatabaseButton.Size = new System.Drawing.Size(190, 80);
            this.CreateDatabaseButton.TabIndex = 0;
            this.CreateDatabaseButton.Text = "Dodaj baze";
            this.CreateDatabaseButton.UseVisualStyleBackColor = true;
            this.CreateDatabaseButton.Click += new System.EventHandler(this.CreateDatabaseButton_Click);
            // 
            // CreateTableButton
            // 
            this.CreateTableButton.Location = new System.Drawing.Point(340, 114);
            this.CreateTableButton.Name = "CreateTableButton";
            this.CreateTableButton.Size = new System.Drawing.Size(190, 80);
            this.CreateTableButton.TabIndex = 1;
            this.CreateTableButton.Text = "Dodaj tabele";
            this.CreateTableButton.UseVisualStyleBackColor = true;
            this.CreateTableButton.Click += new System.EventHandler(this.CreateTableButton_Click);
            // 
            // AddRecordButton
            // 
            this.AddRecordButton.Location = new System.Drawing.Point(634, 114);
            this.AddRecordButton.Name = "AddRecordButton";
            this.AddRecordButton.Size = new System.Drawing.Size(190, 80);
            this.AddRecordButton.TabIndex = 1;
            this.AddRecordButton.Text = "Dodaj rekord";
            this.AddRecordButton.UseVisualStyleBackColor = true;
            this.AddRecordButton.Click += new System.EventHandler(this.AddRecordButton_Click);
            // 
            // tableName
            // 
            this.tableName.Location = new System.Drawing.Point(430, 264);
            this.tableName.Name = "tableName";
            this.tableName.Size = new System.Drawing.Size(100, 20);
            this.tableName.TabIndex = 2;
            this.tableName.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // databaseName
            // 
            this.databaseName.Location = new System.Drawing.Point(139, 264);
            this.databaseName.Name = "databaseName";
            this.databaseName.Size = new System.Drawing.Size(100, 20);
            this.databaseName.TabIndex = 3;
            // 
            // useDatabaseCheckBox
            // 
            this.useDatabaseCheckBox.AutoSize = true;
            this.useDatabaseCheckBox.Checked = true;
            this.useDatabaseCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useDatabaseCheckBox.Location = new System.Drawing.Point(81, 210);
            this.useDatabaseCheckBox.Name = "useDatabaseCheckBox";
            this.useDatabaseCheckBox.Size = new System.Drawing.Size(101, 17);
            this.useDatabaseCheckBox.TabIndex = 4;
            this.useDatabaseCheckBox.Text = "use Database ?";
            this.useDatabaseCheckBox.UseVisualStyleBackColor = true;
            this.useDatabaseCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "nazwa: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "nazwa: ";
            // 
            // useDatabaseComboBox
            // 
            this.useDatabaseComboBox.FormattingEnabled = true;
            this.useDatabaseComboBox.Location = new System.Drawing.Point(81, 65);
            this.useDatabaseComboBox.Name = "useDatabaseComboBox";
            this.useDatabaseComboBox.Size = new System.Drawing.Size(121, 21);
            this.useDatabaseComboBox.TabIndex = 7;
            this.useDatabaseComboBox.SelectedIndexChanged += new System.EventHandler(this.useDatabaseComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Używaj bazy: ";
            this.label3.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(701, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 323);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.useDatabaseComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.useDatabaseCheckBox);
            this.Controls.Add(this.databaseName);
            this.Controls.Add(this.tableName);
            this.Controls.Add(this.AddRecordButton);
            this.Controls.Add(this.CreateTableButton);
            this.Controls.Add(this.CreateDatabaseButton);
            this.Name = "MainWindow";
            this.Text = "Okienko";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button CreateDatabaseButton;
        private System.Windows.Forms.Button CreateTableButton;
        private System.Windows.Forms.Button AddRecordButton;
        private System.Windows.Forms.MaskedTextBox tableName;
        private System.Windows.Forms.MaskedTextBox databaseName;
        private System.Windows.Forms.CheckBox useDatabaseCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox useDatabaseComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

