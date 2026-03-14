namespace Modul3_103022400015
{
    partial class Form1
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
            this.comboBoxSatuanAwal = new System.Windows.Forms.ComboBox();
            this.labelSatuanAwal = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.labelNilaiAwal = new System.Windows.Forms.Label();
            this.textBoxNilaiAwal = new System.Windows.Forms.TextBox();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.labelNilaiAkhir = new System.Windows.Forms.Label();
            this.textBoxNilaiAkhir = new System.Windows.Forms.TextBox();
            this.labelSatuanAkhir = new System.Windows.Forms.Label();
            this.comboBoxSatuanAkhir = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBoxSatuanAwal
            // 
            this.comboBoxSatuanAwal.DisplayMember = "Celcius";
            this.comboBoxSatuanAwal.FormattingEnabled = true;
            this.comboBoxSatuanAwal.Items.AddRange(new object[] {
            "Celcius",
            "Fahrenheit",
            "Kelvin",
            "Reamur"});
            this.comboBoxSatuanAwal.Location = new System.Drawing.Point(72, 139);
            this.comboBoxSatuanAwal.Name = "comboBoxSatuanAwal";
            this.comboBoxSatuanAwal.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSatuanAwal.TabIndex = 0;
            this.comboBoxSatuanAwal.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelSatuanAwal
            // 
            this.labelSatuanAwal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSatuanAwal.Location = new System.Drawing.Point(72, 102);
            this.labelSatuanAwal.Name = "labelSatuanAwal";
            this.labelSatuanAwal.Size = new System.Drawing.Size(121, 23);
            this.labelSatuanAwal.TabIndex = 1;
            this.labelSatuanAwal.Text = "Satuan Awal";
            this.labelSatuanAwal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSatuanAwal.Click += new System.EventHandler(this.labelSatuanAwal_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(233, 182);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 16);
            this.linkLabel1.TabIndex = 2;
            // 
            // labelNilaiAwal
            // 
            this.labelNilaiAwal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelNilaiAwal.Location = new System.Drawing.Point(263, 105);
            this.labelNilaiAwal.Name = "labelNilaiAwal";
            this.labelNilaiAwal.Size = new System.Drawing.Size(100, 23);
            this.labelNilaiAwal.TabIndex = 3;
            this.labelNilaiAwal.Text = "Nilai Awal";
            this.labelNilaiAwal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelNilaiAwal.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxNilaiAwal
            // 
            this.textBoxNilaiAwal.Location = new System.Drawing.Point(263, 141);
            this.textBoxNilaiAwal.Name = "textBoxNilaiAwal";
            this.textBoxNilaiAwal.Size = new System.Drawing.Size(223, 22);
            this.textBoxNilaiAwal.TabIndex = 4;
            this.textBoxNilaiAwal.TextChanged += new System.EventHandler(this.textBoxNilaiAwal_TextChanged);
            // 
            // buttonConvert
            // 
            this.buttonConvert.Location = new System.Drawing.Point(519, 140);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(75, 23);
            this.buttonConvert.TabIndex = 5;
            this.buttonConvert.Text = "Convert\r\n";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // labelNilaiAkhir
            // 
            this.labelNilaiAkhir.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelNilaiAkhir.Location = new System.Drawing.Point(263, 207);
            this.labelNilaiAkhir.Name = "labelNilaiAkhir";
            this.labelNilaiAkhir.Size = new System.Drawing.Size(100, 23);
            this.labelNilaiAkhir.TabIndex = 6;
            this.labelNilaiAkhir.Text = "Nilai Akhir";
            this.labelNilaiAkhir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelNilaiAkhir.Click += new System.EventHandler(this.labelNilaiAkhir_Click);
            // 
            // textBoxNilaiAkhir
            // 
            this.textBoxNilaiAkhir.Location = new System.Drawing.Point(263, 244);
            this.textBoxNilaiAkhir.Name = "textBoxNilaiAkhir";
            this.textBoxNilaiAkhir.ReadOnly = true;
            this.textBoxNilaiAkhir.Size = new System.Drawing.Size(223, 22);
            this.textBoxNilaiAkhir.TabIndex = 7;
            this.textBoxNilaiAkhir.TextChanged += new System.EventHandler(this.textBoxNilaiAkhir_TextChanged);
            // 
            // labelSatuanAkhir
            // 
            this.labelSatuanAkhir.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSatuanAkhir.Location = new System.Drawing.Point(72, 207);
            this.labelSatuanAkhir.Name = "labelSatuanAkhir";
            this.labelSatuanAkhir.Size = new System.Drawing.Size(124, 23);
            this.labelSatuanAkhir.TabIndex = 8;
            this.labelSatuanAkhir.Text = "Satuan Akhir";
            this.labelSatuanAkhir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSatuanAkhir.Click += new System.EventHandler(this.labelSatuanAkhir_Click);
            // 
            // comboBoxSatuanAkhir
            // 
            this.comboBoxSatuanAkhir.FormattingEnabled = true;
            this.comboBoxSatuanAkhir.Items.AddRange(new object[] {
            "Celcius",
            "Fahrenheit",
            "Kelvin",
            "Reamur"});
            this.comboBoxSatuanAkhir.Location = new System.Drawing.Point(72, 244);
            this.comboBoxSatuanAkhir.Name = "comboBoxSatuanAkhir";
            this.comboBoxSatuanAkhir.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSatuanAkhir.TabIndex = 9;
            this.comboBoxSatuanAkhir.SelectedIndexChanged += new System.EventHandler(this.comboBoxSatuanAkhir_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxSatuanAkhir);
            this.Controls.Add(this.labelSatuanAkhir);
            this.Controls.Add(this.textBoxNilaiAkhir);
            this.Controls.Add(this.labelNilaiAkhir);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.textBoxNilaiAwal);
            this.Controls.Add(this.labelNilaiAwal);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.labelSatuanAwal);
            this.Controls.Add(this.comboBoxSatuanAwal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSatuanAwal;
        private System.Windows.Forms.Label labelSatuanAwal;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label labelNilaiAwal;
        private System.Windows.Forms.TextBox textBoxNilaiAwal;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.Label labelNilaiAkhir;
        private System.Windows.Forms.TextBox textBoxNilaiAkhir;
        private System.Windows.Forms.Label labelSatuanAkhir;
        private System.Windows.Forms.ComboBox comboBoxSatuanAkhir;
    }
}

