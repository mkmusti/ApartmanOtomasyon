namespace ApartmanOtomasyon
{
    partial class Giderler
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
            this.cbElektrik = new System.Windows.Forms.CheckBox();
            this.cbSu = new System.Windows.Forms.CheckBox();
            this.cbTemizlik = new System.Windows.Forms.CheckBox();
            this.cbAsansor = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnEkle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbGider = new System.Windows.Forms.ListBox();
            this.lbTutar = new System.Windows.Forms.ListBox();
            this.lbTarih = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbElektrik
            // 
            this.cbElektrik.AutoSize = true;
            this.cbElektrik.Location = new System.Drawing.Point(31, 38);
            this.cbElektrik.Name = "cbElektrik";
            this.cbElektrik.Size = new System.Drawing.Size(80, 24);
            this.cbElektrik.TabIndex = 0;
            this.cbElektrik.Text = "Elektrik";
            this.cbElektrik.UseVisualStyleBackColor = true;
            // 
            // cbSu
            // 
            this.cbSu.AutoSize = true;
            this.cbSu.Location = new System.Drawing.Point(31, 68);
            this.cbSu.Name = "cbSu";
            this.cbSu.Size = new System.Drawing.Size(48, 24);
            this.cbSu.TabIndex = 1;
            this.cbSu.Text = "Su";
            this.cbSu.UseVisualStyleBackColor = true;
            // 
            // cbTemizlik
            // 
            this.cbTemizlik.AutoSize = true;
            this.cbTemizlik.Location = new System.Drawing.Point(31, 128);
            this.cbTemizlik.Name = "cbTemizlik";
            this.cbTemizlik.Size = new System.Drawing.Size(84, 24);
            this.cbTemizlik.TabIndex = 2;
            this.cbTemizlik.Text = "Temizlik";
            this.cbTemizlik.UseVisualStyleBackColor = true;
            // 
            // cbAsansor
            // 
            this.cbAsansor.AutoSize = true;
            this.cbAsansor.Location = new System.Drawing.Point(31, 98);
            this.cbAsansor.Name = "cbAsansor";
            this.cbAsansor.Size = new System.Drawing.Size(87, 24);
            this.cbAsansor.TabIndex = 3;
            this.cbAsansor.Text = "Asansör";
            this.cbAsansor.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tutar :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tarih :";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(268, 33);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown1.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(268, 62);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(120, 26);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(221, 98);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(167, 54);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.cbElektrik);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.cbSu);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.cbTemizlik);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbAsansor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 176);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giderler";
            // 
            // lbGider
            // 
            this.lbGider.FormattingEnabled = true;
            this.lbGider.ItemHeight = 20;
            this.lbGider.Location = new System.Drawing.Point(9, 200);
            this.lbGider.Name = "lbGider";
            this.lbGider.Size = new System.Drawing.Size(139, 264);
            this.lbGider.TabIndex = 10;
            // 
            // lbTutar
            // 
            this.lbTutar.FormattingEnabled = true;
            this.lbTutar.ItemHeight = 20;
            this.lbTutar.Location = new System.Drawing.Point(153, 200);
            this.lbTutar.Name = "lbTutar";
            this.lbTutar.Size = new System.Drawing.Size(139, 264);
            this.lbTutar.TabIndex = 11;
            // 
            // lbTarih
            // 
            this.lbTarih.FormattingEnabled = true;
            this.lbTarih.ItemHeight = 20;
            this.lbTarih.Location = new System.Drawing.Point(297, 200);
            this.lbTarih.Name = "lbTarih";
            this.lbTarih.Size = new System.Drawing.Size(139, 264);
            this.lbTarih.TabIndex = 12;
            // 
            // Giderler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 473);
            this.Controls.Add(this.lbTarih);
            this.Controls.Add(this.lbTutar);
            this.Controls.Add(this.lbGider);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Giderler";
            this.Text = "Giderler";
            this.Load += new System.EventHandler(this.Giderler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox cbElektrik;
        private System.Windows.Forms.CheckBox cbSu;
        private System.Windows.Forms.CheckBox cbTemizlik;
        private System.Windows.Forms.CheckBox cbAsansor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbGider;
        private System.Windows.Forms.ListBox lbTutar;
        private System.Windows.Forms.ListBox lbTarih;
    }
}