namespace görselprog_deney1
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_KadiEK = new System.Windows.Forms.TextBox();
            this.txt_SifreEK = new System.Windows.Forms.TextBox();
            this.btn_girisEK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // txt_KadiEK
            // 
            this.txt_KadiEK.Location = new System.Drawing.Point(194, 53);
            this.txt_KadiEK.Name = "txt_KadiEK";
            this.txt_KadiEK.Size = new System.Drawing.Size(369, 22);
            this.txt_KadiEK.TabIndex = 2;
            this.txt_KadiEK.TabStop = false;
            // 
            // txt_SifreEK
            // 
            this.txt_SifreEK.Location = new System.Drawing.Point(194, 137);
            this.txt_SifreEK.Name = "txt_SifreEK";
            this.txt_SifreEK.Size = new System.Drawing.Size(369, 22);
            this.txt_SifreEK.TabIndex = 3;
            this.txt_SifreEK.TabStop = false;
            // 
            // btn_girisEK
            // 
            this.btn_girisEK.Location = new System.Drawing.Point(263, 212);
            this.btn_girisEK.Name = "btn_girisEK";
            this.btn_girisEK.Size = new System.Drawing.Size(193, 38);
            this.btn_girisEK.TabIndex = 4;
            this.btn_girisEK.Text = "Sisteme Gir";
            this.btn_girisEK.UseVisualStyleBackColor = true;
            this.btn_girisEK.Click += new System.EventHandler(this.btn_girisEK_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 306);
            this.Controls.Add(this.btn_girisEK);
            this.Controls.Add(this.txt_SifreEK);
            this.Controls.Add(this.txt_KadiEK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_KadiEK;
        private System.Windows.Forms.TextBox txt_SifreEK;
        private System.Windows.Forms.Button btn_girisEK;
    }
}

