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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tableName = new System.Windows.Forms.MaskedTextBox();
            this.databaseName = new System.Windows.Forms.MaskedTextBox();
            this.useDatabase = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 80);
            this.button1.TabIndex = 0;
            this.button1.Text = "Dodaj baze";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(340, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 80);
            this.button2.TabIndex = 1;
            this.button2.Text = "Dodaj tabele";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(634, 114);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(190, 80);
            this.button3.TabIndex = 1;
            this.button3.Text = "Dodaj rekord";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            // useDatabase
            // 
            this.useDatabase.AutoSize = true;
            this.useDatabase.Checked = true;
            this.useDatabase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useDatabase.Location = new System.Drawing.Point(81, 210);
            this.useDatabase.Name = "useDatabase";
            this.useDatabase.Size = new System.Drawing.Size(101, 17);
            this.useDatabase.TabIndex = 4;
            this.useDatabase.Text = "use Database ?";
            this.useDatabase.UseVisualStyleBackColor = true;
            this.useDatabase.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "nazwa: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "nazwa: ";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 323);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.useDatabase);
            this.Controls.Add(this.databaseName);
            this.Controls.Add(this.tableName);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "MainWindow";
            this.Text = "Okienko";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.MaskedTextBox tableName;
        public System.Windows.Forms.MaskedTextBox databaseName;
        public System.Windows.Forms.CheckBox useDatabase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

