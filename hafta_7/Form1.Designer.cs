namespace hafta_7
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtmeyve = new System.Windows.Forms.TextBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.lstmeyveler = new System.Windows.Forms.CheckedListBox();
            this.btnaktar = new System.Windows.Forms.Button();
            this.lstsecilenler = new System.Windows.Forms.ListBox();
            this.btntemizle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Meyve";
            // 
            // txtmeyve
            // 
            this.txtmeyve.Location = new System.Drawing.Point(57, 47);
            this.txtmeyve.Name = "txtmeyve";
            this.txtmeyve.Size = new System.Drawing.Size(100, 22);
            this.txtmeyve.TabIndex = 1;
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(57, 108);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(75, 23);
            this.btnekle.TabIndex = 2;
            this.btnekle.Text = "ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // lstmeyveler
            // 
            this.lstmeyveler.FormattingEnabled = true;
            this.lstmeyveler.Location = new System.Drawing.Point(57, 160);
            this.lstmeyveler.Name = "lstmeyveler";
            this.lstmeyveler.Size = new System.Drawing.Size(139, 259);
            this.lstmeyveler.TabIndex = 3;
            // 
            // btnaktar
            // 
            this.btnaktar.Location = new System.Drawing.Point(211, 247);
            this.btnaktar.Name = "btnaktar";
            this.btnaktar.Size = new System.Drawing.Size(75, 23);
            this.btnaktar.TabIndex = 5;
            this.btnaktar.Text = "aktar";
            this.btnaktar.UseVisualStyleBackColor = true;
            this.btnaktar.Click += new System.EventHandler(this.btnaktar_Click);
            // 
            // lstsecilenler
            // 
            this.lstsecilenler.FormattingEnabled = true;
            this.lstsecilenler.ItemHeight = 16;
            this.lstsecilenler.Location = new System.Drawing.Point(303, 160);
            this.lstsecilenler.Name = "lstsecilenler";
            this.lstsecilenler.Size = new System.Drawing.Size(140, 260);
            this.lstsecilenler.TabIndex = 6;
            // 
            // btntemizle
            // 
            this.btntemizle.Location = new System.Drawing.Point(174, 108);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(75, 23);
            this.btntemizle.TabIndex = 7;
            this.btntemizle.Text = "temizle";
            this.btntemizle.UseVisualStyleBackColor = true;
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btntemizle);
            this.Controls.Add(this.lstsecilenler);
            this.Controls.Add(this.btnaktar);
            this.Controls.Add(this.lstmeyveler);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.txtmeyve);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmeyve;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.CheckedListBox lstmeyveler;
        private System.Windows.Forms.Button btnaktar;
        private System.Windows.Forms.ListBox lstsecilenler;
        private System.Windows.Forms.Button btntemizle;
    }
}

