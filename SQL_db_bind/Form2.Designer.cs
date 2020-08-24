namespace SQL_db_bind
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idnarzedziaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwapodstawowaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwadodatkowaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numerinwentarzowyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iloscDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idrodzajnarzedziaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.narzedzieunikatoweDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.narzedziaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._marcin_bohmDataSet2 = new SQL_db_bind._marcin_bohmDataSet2();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.rodzajNarzedziaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._marcin_bohmDataSet = new SQL_db_bind._marcin_bohmDataSet();
            this._DESKTOP_H65VDV2_SQLEXPRESSDataSet = new SQL_db_bind._DESKTOP_H65VDV2_SQLEXPRESSDataSet();
            this.dESKTOPH65VDV2SQLEXPRESSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rodzaj_NarzedziaTableAdapter = new SQL_db_bind._marcin_bohmDataSetTableAdapters.Rodzaj_NarzedziaTableAdapter();
            this.narzedziaTableAdapter = new SQL_db_bind._marcin_bohmDataSet2TableAdapters.NarzedziaTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.narzedziaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._marcin_bohmDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rodzajNarzedziaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._marcin_bohmDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._DESKTOP_H65VDV2_SQLEXPRESSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dESKTOPH65VDV2SQLEXPRESSDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idnarzedziaDataGridViewTextBoxColumn,
            this.nazwapodstawowaDataGridViewTextBoxColumn,
            this.nazwadodatkowaDataGridViewTextBoxColumn,
            this.numerinwentarzowyDataGridViewTextBoxColumn,
            this.iloscDataGridViewTextBoxColumn,
            this.idrodzajnarzedziaDataGridViewTextBoxColumn,
            this.narzedzieunikatoweDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.narzedziaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(538, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(552, 426);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idnarzedziaDataGridViewTextBoxColumn
            // 
            this.idnarzedziaDataGridViewTextBoxColumn.DataPropertyName = "id_narzedzia";
            this.idnarzedziaDataGridViewTextBoxColumn.HeaderText = "id_narzedzia";
            this.idnarzedziaDataGridViewTextBoxColumn.Name = "idnarzedziaDataGridViewTextBoxColumn";
            this.idnarzedziaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazwapodstawowaDataGridViewTextBoxColumn
            // 
            this.nazwapodstawowaDataGridViewTextBoxColumn.DataPropertyName = "nazwa_podstawowa";
            this.nazwapodstawowaDataGridViewTextBoxColumn.HeaderText = "nazwa_podstawowa";
            this.nazwapodstawowaDataGridViewTextBoxColumn.Name = "nazwapodstawowaDataGridViewTextBoxColumn";
            this.nazwapodstawowaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazwadodatkowaDataGridViewTextBoxColumn
            // 
            this.nazwadodatkowaDataGridViewTextBoxColumn.DataPropertyName = "nazwa_dodatkowa";
            this.nazwadodatkowaDataGridViewTextBoxColumn.HeaderText = "nazwa_dodatkowa";
            this.nazwadodatkowaDataGridViewTextBoxColumn.Name = "nazwadodatkowaDataGridViewTextBoxColumn";
            this.nazwadodatkowaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numerinwentarzowyDataGridViewTextBoxColumn
            // 
            this.numerinwentarzowyDataGridViewTextBoxColumn.DataPropertyName = "numer_inwentarzowy";
            this.numerinwentarzowyDataGridViewTextBoxColumn.HeaderText = "numer_inwentarzowy";
            this.numerinwentarzowyDataGridViewTextBoxColumn.Name = "numerinwentarzowyDataGridViewTextBoxColumn";
            this.numerinwentarzowyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iloscDataGridViewTextBoxColumn
            // 
            this.iloscDataGridViewTextBoxColumn.DataPropertyName = "ilosc";
            this.iloscDataGridViewTextBoxColumn.HeaderText = "ilosc";
            this.iloscDataGridViewTextBoxColumn.Name = "iloscDataGridViewTextBoxColumn";
            this.iloscDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idrodzajnarzedziaDataGridViewTextBoxColumn
            // 
            this.idrodzajnarzedziaDataGridViewTextBoxColumn.DataPropertyName = "id_rodzaj_narzedzia";
            this.idrodzajnarzedziaDataGridViewTextBoxColumn.HeaderText = "id_rodzaj_narzedzia";
            this.idrodzajnarzedziaDataGridViewTextBoxColumn.Name = "idrodzajnarzedziaDataGridViewTextBoxColumn";
            this.idrodzajnarzedziaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // narzedzieunikatoweDataGridViewCheckBoxColumn
            // 
            this.narzedzieunikatoweDataGridViewCheckBoxColumn.DataPropertyName = "narzedzie_unikatowe";
            this.narzedzieunikatoweDataGridViewCheckBoxColumn.HeaderText = "narzedzie_unikatowe";
            this.narzedzieunikatoweDataGridViewCheckBoxColumn.Name = "narzedzieunikatoweDataGridViewCheckBoxColumn";
            this.narzedzieunikatoweDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // narzedziaBindingSource
            // 
            this.narzedziaBindingSource.DataMember = "Narzedzia";
            this.narzedziaBindingSource.DataSource = this._marcin_bohmDataSet2;
            // 
            // _marcin_bohmDataSet2
            // 
            this._marcin_bohmDataSet2.DataSetName = "_marcin_bohmDataSet2";
            this._marcin_bohmDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(417, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "Reload";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 398);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 224);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 30);
            this.button3.TabIndex = 3;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(74, 223);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(58, 31);
            this.button4.TabIndex = 5;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(220, 12);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(220, 41);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(220, 70);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 19);
            this.textBox4.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(57, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 14);
            this.label2.TabIndex = 12;
            this.label2.Text = "nazwa_podstawowa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(57, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 14);
            this.label3.TabIndex = 13;
            this.label3.Text = "nazwa_dodatkowa";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "numer_inwentarzowy";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(90, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "Ilosc";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "id_rodzaj_narzedzia";
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(51, 158);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(134, 40);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "narzedzie_unikatowe";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(220, 97);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 20;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(220, 132);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 121);
            this.listBox1.TabIndex = 21;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // rodzajNarzedziaBindingSource
            // 
            this.rodzajNarzedziaBindingSource.DataMember = "Rodzaj_Narzedzia";
            this.rodzajNarzedziaBindingSource.DataSource = this._marcin_bohmDataSet;
            // 
            // _marcin_bohmDataSet
            // 
            this._marcin_bohmDataSet.DataSetName = "_marcin_bohmDataSet";
            this._marcin_bohmDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // _DESKTOP_H65VDV2_SQLEXPRESSDataSet
            // 
            this._DESKTOP_H65VDV2_SQLEXPRESSDataSet.DataSetName = "_DESKTOP_H65VDV2_SQLEXPRESSDataSet";
            this._DESKTOP_H65VDV2_SQLEXPRESSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dESKTOPH65VDV2SQLEXPRESSDataSetBindingSource
            // 
            this.dESKTOPH65VDV2SQLEXPRESSDataSetBindingSource.DataSource = this._DESKTOP_H65VDV2_SQLEXPRESSDataSet;
            this.dESKTOPH65VDV2SQLEXPRESSDataSetBindingSource.Position = 0;
            // 
            // rodzaj_NarzedziaTableAdapter
            // 
            this.rodzaj_NarzedziaTableAdapter.ClearBeforeFill = true;
            // 
            // narzedziaTableAdapter
            // 
            this.narzedziaTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(298, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Add +1 ilosc to all";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(308, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Add +1 ilosc to:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(394, 288);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(93, 23);
            this.button5.TabIndex = 25;
            this.button5.Text = "Add";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(394, 363);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(93, 23);
            this.button6.TabIndex = 26;
            this.button6.Text = "Add";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(138, 222);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(58, 32);
            this.button7.TabIndex = 27;
            this.button7.Text = "Update";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(308, 353);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "(id_narzedzia)";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(394, 340);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(93, 20);
            this.numericUpDown3.TabIndex = 32;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 450);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.narzedziaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._marcin_bohmDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rodzajNarzedziaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._marcin_bohmDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._DESKTOP_H65VDV2_SQLEXPRESSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dESKTOPH65VDV2SQLEXPRESSDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.BindingSource dESKTOPH65VDV2SQLEXPRESSDataSetBindingSource;
        private _DESKTOP_H65VDV2_SQLEXPRESSDataSet _DESKTOP_H65VDV2_SQLEXPRESSDataSet;
        private _marcin_bohmDataSet _marcin_bohmDataSet;
        private System.Windows.Forms.BindingSource rodzajNarzedziaBindingSource;
        private _marcin_bohmDataSetTableAdapters.Rodzaj_NarzedziaTableAdapter rodzaj_NarzedziaTableAdapter;
        private _marcin_bohmDataSet2 _marcin_bohmDataSet2;
        private System.Windows.Forms.BindingSource narzedziaBindingSource;
        private _marcin_bohmDataSet2TableAdapters.NarzedziaTableAdapter narzedziaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idnarzedziaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwapodstawowaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwadodatkowaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerinwentarzowyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iloscDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idrodzajnarzedziaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn narzedzieunikatoweDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
    }
}