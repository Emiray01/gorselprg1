namespace Hafta_4
{
    partial class frm_anamenu
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
            this.btn_formgec = new System.Windows.Forms.Button();
            this.btn_drsformgec = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.derslerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nüfusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.java_chb = new System.Windows.Forms.CheckBox();
            this.c_chb = new System.Windows.Forms.CheckBox();
            this.csh_cbh = new System.Windows.Forms.CheckBox();
            this.btngonder = new System.Windows.Forms.Button();
            this.rdbbayan = new System.Windows.Forms.RadioButton();
            this.rdbbay = new System.Windows.Forms.RadioButton();
            this.btngonder2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_formgec
            // 
            this.btn_formgec.Location = new System.Drawing.Point(608, 87);
            this.btn_formgec.Name = "btn_formgec";
            this.btn_formgec.Size = new System.Drawing.Size(137, 30);
            this.btn_formgec.TabIndex = 0;
            this.btn_formgec.Text = "Nüfus Forma Geç";
            this.btn_formgec.UseVisualStyleBackColor = true;
            this.btn_formgec.Click += new System.EventHandler(this.btn_formgec_Click);
            // 
            // btn_drsformgec
            // 
            this.btn_drsformgec.Location = new System.Drawing.Point(771, 87);
            this.btn_drsformgec.Name = "btn_drsformgec";
            this.btn_drsformgec.Size = new System.Drawing.Size(137, 30);
            this.btn_drsformgec.TabIndex = 1;
            this.btn_drsformgec.Text = "Dersler forma geç";
            this.btn_drsformgec.UseVisualStyleBackColor = true;
            this.btn_drsformgec.Click += new System.EventHandler(this.btn_drsformgec_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menüToolStripMenuItem,
            this.raporlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(982, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menüToolStripMenuItem
            // 
            this.menüToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.derslerToolStripMenuItem,
            this.nüfusToolStripMenuItem});
            this.menüToolStripMenuItem.Name = "menüToolStripMenuItem";
            this.menüToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menüToolStripMenuItem.Text = "Menü";
            // 
            // derslerToolStripMenuItem
            // 
            this.derslerToolStripMenuItem.Name = "derslerToolStripMenuItem";
            this.derslerToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.derslerToolStripMenuItem.Text = "Dersler";
            // 
            // nüfusToolStripMenuItem
            // 
            this.nüfusToolStripMenuItem.Name = "nüfusToolStripMenuItem";
            this.nüfusToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.nüfusToolStripMenuItem.Text = "Nüfus";
            this.nüfusToolStripMenuItem.Click += new System.EventHandler(this.nüfusToolStripMenuItem_Click);
            // 
            // raporlarToolStripMenuItem
            // 
            this.raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
            this.raporlarToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.raporlarToolStripMenuItem.Text = "Raporlar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(811, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bildiğiniz Diller:";
            // 
            // java_chb
            // 
            this.java_chb.AutoSize = true;
            this.java_chb.Location = new System.Drawing.Point(814, 241);
            this.java_chb.Name = "java_chb";
            this.java_chb.Size = new System.Drawing.Size(59, 20);
            this.java_chb.TabIndex = 5;
            this.java_chb.Text = "Java";
            this.java_chb.UseVisualStyleBackColor = true;
            // 
            // c_chb
            // 
            this.c_chb.AutoSize = true;
            this.c_chb.Location = new System.Drawing.Point(814, 286);
            this.c_chb.Name = "c_chb";
            this.c_chb.Size = new System.Drawing.Size(52, 20);
            this.c_chb.TabIndex = 6;
            this.c_chb.Text = "C++";
            this.c_chb.UseVisualStyleBackColor = true;
            // 
            // csh_cbh
            // 
            this.csh_cbh.AutoSize = true;
            this.csh_cbh.Location = new System.Drawing.Point(814, 332);
            this.csh_cbh.Name = "csh_cbh";
            this.csh_cbh.Size = new System.Drawing.Size(45, 20);
            this.csh_cbh.TabIndex = 7;
            this.csh_cbh.Text = "C#";
            this.csh_cbh.UseVisualStyleBackColor = true;
            // 
            // btngonder
            // 
            this.btngonder.Location = new System.Drawing.Point(814, 400);
            this.btngonder.Name = "btngonder";
            this.btngonder.Size = new System.Drawing.Size(75, 23);
            this.btngonder.TabIndex = 8;
            this.btngonder.Text = "Gönder";
            this.btngonder.UseVisualStyleBackColor = true;
            this.btngonder.Click += new System.EventHandler(this.btngonder_Click);
            // 
            // rdbbayan
            // 
            this.rdbbayan.AutoSize = true;
            this.rdbbayan.Location = new System.Drawing.Point(624, 177);
            this.rdbbayan.Name = "rdbbayan";
            this.rdbbayan.Size = new System.Drawing.Size(67, 20);
            this.rdbbayan.TabIndex = 9;
            this.rdbbayan.TabStop = true;
            this.rdbbayan.Text = "Bayan";
            this.rdbbayan.UseVisualStyleBackColor = true;
            // 
            // rdbbay
            // 
            this.rdbbay.AutoSize = true;
            this.rdbbay.Location = new System.Drawing.Point(624, 213);
            this.rdbbay.Name = "rdbbay";
            this.rdbbay.Size = new System.Drawing.Size(52, 20);
            this.rdbbay.TabIndex = 10;
            this.rdbbay.TabStop = true;
            this.rdbbay.Text = "Bay";
            this.rdbbay.UseVisualStyleBackColor = true;
            // 
            // btngonder2
            // 
            this.btngonder2.Location = new System.Drawing.Point(624, 267);
            this.btngonder2.Name = "btngonder2";
            this.btngonder2.Size = new System.Drawing.Size(67, 23);
            this.btngonder2.TabIndex = 11;
            this.btngonder2.Text = "Gönder";
            this.btngonder2.UseVisualStyleBackColor = true;
            this.btngonder2.Click += new System.EventHandler(this.btngonder2_Click);
            // 
            // frm_anamenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(982, 496);
            this.Controls.Add(this.btngonder2);
            this.Controls.Add(this.rdbbay);
            this.Controls.Add(this.rdbbayan);
            this.Controls.Add(this.btngonder);
            this.Controls.Add(this.csh_cbh);
            this.Controls.Add(this.c_chb);
            this.Controls.Add(this.java_chb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btn_drsformgec);
            this.Controls.Add(this.btn_formgec);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_anamenu";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_formgec;
        private System.Windows.Forms.Button btn_drsformgec;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem derslerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nüfusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlarToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox java_chb;
        private System.Windows.Forms.CheckBox c_chb;
        private System.Windows.Forms.CheckBox csh_cbh;
        private System.Windows.Forms.Button btngonder;
        private System.Windows.Forms.RadioButton rdbbayan;
        private System.Windows.Forms.RadioButton rdbbay;
        private System.Windows.Forms.Button btngonder2;
    }
}

