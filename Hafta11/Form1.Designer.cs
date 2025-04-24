namespace Hafta11
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
            this.btn_bagverigetir = new System.Windows.Forms.Button();
            this.lstveriler = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_bagverigetir
            // 
            this.btn_bagverigetir.Location = new System.Drawing.Point(160, 52);
            this.btn_bagverigetir.Name = "btn_bagverigetir";
            this.btn_bagverigetir.Size = new System.Drawing.Size(324, 41);
            this.btn_bagverigetir.TabIndex = 0;
            this.btn_bagverigetir.Text = "bağlantılı veri getir";
            this.btn_bagverigetir.UseVisualStyleBackColor = true;
            this.btn_bagverigetir.Click += new System.EventHandler(this.btn_bagverigetir_Click);
            // 
            // lstveriler
            // 
            this.lstveriler.FormattingEnabled = true;
            this.lstveriler.ItemHeight = 16;
            this.lstveriler.Location = new System.Drawing.Point(160, 111);
            this.lstveriler.Name = "lstveriler";
            this.lstveriler.Size = new System.Drawing.Size(324, 196);
            this.lstveriler.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstveriler);
            this.Controls.Add(this.btn_bagverigetir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_bagverigetir;
        private System.Windows.Forms.ListBox lstveriler;
    }
}

