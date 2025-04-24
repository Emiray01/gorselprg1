namespace hafta3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt_aciklama = new TextBox();
            label1 = new Label();
            txt_enter = new TextBox();
            button1 = new Button();
            maskedTextBox1 = new MaskedTextBox();
            btn_mesaj = new Button();
            SuspendLayout();
            // 
            // txt_aciklama
            // 
            txt_aciklama.Location = new Point(47, 91);
            txt_aciklama.Name = "txt_aciklama";
            txt_aciklama.Size = new Size(290, 27);
            txt_aciklama.TabIndex = 2;
            txt_aciklama.TextChanged += txt_aciklama_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 44);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // txt_enter
            // 
            txt_enter.Location = new Point(47, 166);
            txt_enter.Name = "txt_enter";
            txt_enter.Size = new Size(290, 27);
            txt_enter.TabIndex = 4;
            txt_enter.KeyPress += txt_enter_KeyPress;
            // 
            // button1
            // 
            button1.Location = new Point(401, 264);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.MouseUp += button1_MouseUp;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(443, 140);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(125, 27);
            maskedTextBox1.TabIndex = 6;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // btn_mesaj
            // 
            btn_mesaj.Location = new Point(401, 350);
            btn_mesaj.Name = "btn_mesaj";
            btn_mesaj.Size = new Size(94, 29);
            btn_mesaj.TabIndex = 7;
            btn_mesaj.Text = "mesaj ver";
            btn_mesaj.UseVisualStyleBackColor = true;
            btn_mesaj.Click += btn_mesaj_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_mesaj);
            Controls.Add(maskedTextBox1);
            Controls.Add(button1);
            Controls.Add(txt_enter);
            Controls.Add(label1);
            Controls.Add(txt_aciklama);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_aciklama;
        private Label label1;
        private TextBox txt_enter;
        private Button button1;
        private MaskedTextBox maskedTextBox1;
        private Button btn_mesaj;
    }
}
