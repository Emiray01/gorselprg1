namespace hafta_5
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
            this.cmb_iller = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_renk = new System.Windows.Forms.Button();
            this.btn_pasif = new System.Windows.Forms.Button();
            this.btn_aktif = new System.Windows.Forms.Button();
            this.lb_sehirler = new System.Windows.Forms.ListBox();
            this.btn_veriekle = new System.Windows.Forms.Button();
            this.txt_sehir = new System.Windows.Forms.TextBox();
            this.btn_sehirekle = new System.Windows.Forms.Button();
            this.bnt_sehirsil = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_iller
            // 
            this.cmb_iller.FormattingEnabled = true;
            this.cmb_iller.Location = new System.Drawing.Point(6, 37);
            this.cmb_iller.Name = "cmb_iller";
            this.cmb_iller.Size = new System.Drawing.Size(121, 24);
            this.cmb_iller.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "İller:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.cmb_iller);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 196);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.bnt_sehirsil);
            this.panel1.Controls.Add(this.btn_sehirekle);
            this.panel1.Controls.Add(this.txt_sehir);
            this.panel1.Controls.Add(this.btn_renk);
            this.panel1.Location = new System.Drawing.Point(287, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 196);
            this.panel1.TabIndex = 3;
            // 
            // btn_renk
            // 
            this.btn_renk.Location = new System.Drawing.Point(155, 169);
            this.btn_renk.Name = "btn_renk";
            this.btn_renk.Size = new System.Drawing.Size(100, 24);
            this.btn_renk.TabIndex = 4;
            this.btn_renk.Text = "Renk Değiştir";
            this.btn_renk.UseVisualStyleBackColor = true;
            this.btn_renk.Click += new System.EventHandler(this.btn_renk_Click);
            // 
            // btn_pasif
            // 
            this.btn_pasif.Location = new System.Drawing.Point(299, 214);
            this.btn_pasif.Name = "btn_pasif";
            this.btn_pasif.Size = new System.Drawing.Size(75, 24);
            this.btn_pasif.TabIndex = 4;
            this.btn_pasif.Text = "pasif";
            this.btn_pasif.UseVisualStyleBackColor = true;
            this.btn_pasif.Click += new System.EventHandler(this.btn_pasif_Click);
            // 
            // btn_aktif
            // 
            this.btn_aktif.Location = new System.Drawing.Point(380, 214);
            this.btn_aktif.Name = "btn_aktif";
            this.btn_aktif.Size = new System.Drawing.Size(75, 24);
            this.btn_aktif.TabIndex = 5;
            this.btn_aktif.Text = "Aktif";
            this.btn_aktif.UseVisualStyleBackColor = true;
            this.btn_aktif.Click += new System.EventHandler(this.btn_aktif_Click);
            // 
            // lb_sehirler
            // 
            this.lb_sehirler.FormattingEnabled = true;
            this.lb_sehirler.ItemHeight = 16;
            this.lb_sehirler.Items.AddRange(new object[] {
            "Adana",
            "Ankara",
            "Aydın",
            "Muğla",
            "Hakkari"});
            this.lb_sehirler.Location = new System.Drawing.Point(551, 12);
            this.lb_sehirler.Name = "lb_sehirler";
            this.lb_sehirler.Size = new System.Drawing.Size(133, 196);
            this.lb_sehirler.TabIndex = 6;
            // 
            // btn_veriekle
            // 
            this.btn_veriekle.Location = new System.Drawing.Point(551, 214);
            this.btn_veriekle.Name = "btn_veriekle";
            this.btn_veriekle.Size = new System.Drawing.Size(94, 43);
            this.btn_veriekle.TabIndex = 7;
            this.btn_veriekle.Text = "diziden veri ekleme";
            this.btn_veriekle.UseVisualStyleBackColor = true;
            this.btn_veriekle.Click += new System.EventHandler(this.btn_veriekle_Click);
            // 
            // txt_sehir
            // 
            this.txt_sehir.Location = new System.Drawing.Point(3, 12);
            this.txt_sehir.Name = "txt_sehir";
            this.txt_sehir.Size = new System.Drawing.Size(121, 22);
            this.txt_sehir.TabIndex = 8;
            // 
            // btn_sehirekle
            // 
            this.btn_sehirekle.Location = new System.Drawing.Point(22, 51);
            this.btn_sehirekle.Name = "btn_sehirekle";
            this.btn_sehirekle.Size = new System.Drawing.Size(102, 23);
            this.btn_sehirekle.TabIndex = 9;
            this.btn_sehirekle.Text = "Şehir Ekle";
            this.btn_sehirekle.UseVisualStyleBackColor = true;
            this.btn_sehirekle.Click += new System.EventHandler(this.btn_sehirekle_Click);
            // 
            // bnt_sehirsil
            // 
            this.bnt_sehirsil.Location = new System.Drawing.Point(22, 85);
            this.bnt_sehirsil.Name = "bnt_sehirsil";
            this.bnt_sehirsil.Size = new System.Drawing.Size(102, 23);
            this.bnt_sehirsil.TabIndex = 10;
            this.bnt_sehirsil.Text = "Şehir Sil";
            this.bnt_sehirsil.UseVisualStyleBackColor = true;
            this.bnt_sehirsil.Click += new System.EventHandler(this.bnt_sehirsil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_veriekle);
            this.Controls.Add(this.lb_sehirler);
            this.Controls.Add(this.btn_aktif);
            this.Controls.Add(this.btn_pasif);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_iller;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_renk;
        private System.Windows.Forms.Button btn_pasif;
        private System.Windows.Forms.Button btn_aktif;
        private System.Windows.Forms.ListBox lb_sehirler;
        private System.Windows.Forms.Button btn_veriekle;
        private System.Windows.Forms.Button btn_sehirekle;
        private System.Windows.Forms.TextBox txt_sehir;
        private System.Windows.Forms.Button bnt_sehirsil;
    }
}

