namespace MessageCrypter
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
            this.lbl_wToCrypte = new System.Windows.Forms.Label();
            this.tbx_MessageACrypter = new System.Windows.Forms.TextBox();
            this.btn_Crypte = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_MessageDecrypte = new System.Windows.Forms.TextBox();
            this.btn_Decrypte = new System.Windows.Forms.Button();
            this.lbl_Cle = new System.Windows.Forms.Label();
            this.tbx_Cle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_wToCrypte
            // 
            this.lbl_wToCrypte.AutoSize = true;
            this.lbl_wToCrypte.Location = new System.Drawing.Point(116, 114);
            this.lbl_wToCrypte.Name = "lbl_wToCrypte";
            this.lbl_wToCrypte.Size = new System.Drawing.Size(86, 15);
            this.lbl_wToCrypte.TabIndex = 0;
            this.lbl_wToCrypte.Text = "Texte à crypter:";
            // 
            // tbx_MessageACrypter
            // 
            this.tbx_MessageACrypter.Location = new System.Drawing.Point(208, 111);
            this.tbx_MessageACrypter.Name = "tbx_MessageACrypter";
            this.tbx_MessageACrypter.Size = new System.Drawing.Size(432, 23);
            this.tbx_MessageACrypter.TabIndex = 1;
            // 
            // btn_Crypte
            // 
            this.btn_Crypte.Location = new System.Drawing.Point(646, 110);
            this.btn_Crypte.Name = "btn_Crypte";
            this.btn_Crypte.Size = new System.Drawing.Size(75, 23);
            this.btn_Crypte.TabIndex = 2;
            this.btn_Crypte.Text = "Crypter";
            this.btn_Crypte.UseVisualStyleBackColor = true;
            this.btn_Crypte.Click += new System.EventHandler(this.btn_Crypte_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Texte à descrypter :";
            // 
            // tbx_MessageDecrypte
            // 
            this.tbx_MessageDecrypte.Location = new System.Drawing.Point(208, 167);
            this.tbx_MessageDecrypte.Name = "tbx_MessageDecrypte";
            this.tbx_MessageDecrypte.Size = new System.Drawing.Size(432, 23);
            this.tbx_MessageDecrypte.TabIndex = 4;
            // 
            // btn_Decrypte
            // 
            this.btn_Decrypte.Location = new System.Drawing.Point(646, 167);
            this.btn_Decrypte.Name = "btn_Decrypte";
            this.btn_Decrypte.Size = new System.Drawing.Size(75, 23);
            this.btn_Decrypte.TabIndex = 5;
            this.btn_Decrypte.Text = "Decrypter";
            this.btn_Decrypte.UseVisualStyleBackColor = true;
            this.btn_Decrypte.Click += new System.EventHandler(this.btn_Decrypte_Click);
            // 
            // lbl_Cle
            // 
            this.lbl_Cle.AutoSize = true;
            this.lbl_Cle.Location = new System.Drawing.Point(208, 275);
            this.lbl_Cle.Name = "lbl_Cle";
            this.lbl_Cle.Size = new System.Drawing.Size(52, 15);
            this.lbl_Cle.TabIndex = 7;
            this.lbl_Cle.Text = "Votre clé";
            // 
            // tbx_Cle
            // 
            this.tbx_Cle.Location = new System.Drawing.Point(266, 272);
            this.tbx_Cle.Name = "tbx_Cle";
            this.tbx_Cle.Size = new System.Drawing.Size(295, 23);
            this.tbx_Cle.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbx_Cle);
            this.Controls.Add(this.lbl_Cle);
            this.Controls.Add(this.btn_Decrypte);
            this.Controls.Add(this.tbx_MessageDecrypte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Crypte);
            this.Controls.Add(this.tbx_MessageACrypter);
            this.Controls.Add(this.lbl_wToCrypte);
            this.Name = "Form1";
            this.Text = "Texte à descrypter :";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_wToCrypte;
        private System.Windows.Forms.TextBox tbx_MessageACrypter;
        private System.Windows.Forms.Button btn_Crypte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_MessageDecrypte;
        private System.Windows.Forms.Button btn_Decrypte;
        private System.Windows.Forms.Label lbl_Cle;
        private System.Windows.Forms.TextBox tbx_Cle;
    }
}

