namespace ApartmanOtomasyon
{
    partial class Gelirler
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxDaireNo = new System.Windows.Forms.ComboBox();
            this.upDown = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnEkle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbDaireNo = new System.Windows.Forms.ListBox();
            this.lbTutar = new System.Windows.Forms.ListBox();
            this.lbTarih = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.upDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Daire Numarası :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tarih :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 61);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tutar :";
            // 
            // cbxDaireNo
            // 
            this.cbxDaireNo.FormattingEnabled = true;
            this.cbxDaireNo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbxDaireNo.Location = new System.Drawing.Point(139, 26);
            this.cbxDaireNo.Name = "cbxDaireNo";
            this.cbxDaireNo.Size = new System.Drawing.Size(153, 28);
            this.cbxDaireNo.TabIndex = 3;
            // 
            // upDown
            // 
            this.upDown.Location = new System.Drawing.Point(139, 54);
            this.upDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.upDown.Name = "upDown";
            this.upDown.Size = new System.Drawing.Size(153, 27);
            this.upDown.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(139, 81);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(153, 27);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(323, 26);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(95, 82);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.upDown);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbxDaireNo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 114);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gelirler";
            // 
            // lbDaireNo
            // 
            this.lbDaireNo.FormattingEnabled = true;
            this.lbDaireNo.ItemHeight = 20;
            this.lbDaireNo.Location = new System.Drawing.Point(12, 149);
            this.lbDaireNo.Name = "lbDaireNo";
            this.lbDaireNo.Size = new System.Drawing.Size(143, 224);
            this.lbDaireNo.TabIndex = 10;
            // 
            // lbTutar
            // 
            this.lbTutar.FormattingEnabled = true;
            this.lbTutar.ItemHeight = 20;
            this.lbTutar.Location = new System.Drawing.Point(158, 149);
            this.lbTutar.Name = "lbTutar";
            this.lbTutar.Size = new System.Drawing.Size(143, 224);
            this.lbTutar.TabIndex = 11;
            // 
            // lbTarih
            // 
            this.lbTarih.FormattingEnabled = true;
            this.lbTarih.ItemHeight = 20;
            this.lbTarih.Location = new System.Drawing.Point(304, 149);
            this.lbTarih.Name = "lbTarih";
            this.lbTarih.Size = new System.Drawing.Size(143, 224);
            this.lbTarih.TabIndex = 12;
            // 
            // Gelirler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 384);
            this.Controls.Add(this.lbTarih);
            this.Controls.Add(this.lbTutar);
            this.Controls.Add(this.lbDaireNo);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Old English Text MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Gelirler";
            this.Text = "Gelirler";
            this.Load += new System.EventHandler(this.Gelirler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.upDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxDaireNo;
        private System.Windows.Forms.NumericUpDown upDown;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbDaireNo;
        private System.Windows.Forms.ListBox lbTutar;
        private System.Windows.Forms.ListBox lbTarih;
    }
}