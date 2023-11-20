namespace form28
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
            this.cmbCiftSayi = new System.Windows.Forms.ComboBox();
            this.btnAktar = new System.Windows.Forms.Button();
            this.lbSayilar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cmbCiftSayi
            // 
            this.cmbCiftSayi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbCiftSayi.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCiftSayi.FormattingEnabled = true;
            this.cmbCiftSayi.Location = new System.Drawing.Point(38, 331);
            this.cmbCiftSayi.Name = "cmbCiftSayi";
            this.cmbCiftSayi.Size = new System.Drawing.Size(187, 26);
            this.cmbCiftSayi.TabIndex = 0;
            // 
            // btnAktar
            // 
            this.btnAktar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAktar.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAktar.Location = new System.Drawing.Point(38, 250);
            this.btnAktar.Name = "btnAktar";
            this.btnAktar.Size = new System.Drawing.Size(187, 52);
            this.btnAktar.TabIndex = 1;
            this.btnAktar.Text = "ÇİFT SAYİLARI AKTAR";
            this.btnAktar.UseVisualStyleBackColor = false;
            this.btnAktar.Click += new System.EventHandler(this.btnAktar_Click);
            // 
            // lbSayilar
            // 
            this.lbSayilar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbSayilar.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSayilar.FormattingEnabled = true;
            this.lbSayilar.ItemHeight = 18;
            this.lbSayilar.Location = new System.Drawing.Point(38, 25);
            this.lbSayilar.Name = "lbSayilar";
            this.lbSayilar.Size = new System.Drawing.Size(187, 202);
            this.lbSayilar.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(246, 388);
            this.Controls.Add(this.lbSayilar);
            this.Controls.Add(this.btnAktar);
            this.Controls.Add(this.cmbCiftSayi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCiftSayi;
        private System.Windows.Forms.Button btnAktar;
        private System.Windows.Forms.ListBox lbSayilar;
    }
}

