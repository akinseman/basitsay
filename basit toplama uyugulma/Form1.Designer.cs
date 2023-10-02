namespace basit_toplama_uyugulma
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
            this.lblSayı1 = new System.Windows.Forms.Label();
            this.lblSayı2 = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.txtSayı1 = new System.Windows.Forms.TextBox();
            this.txtSayı2 = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSayı1
            // 
            this.lblSayı1.AutoSize = true;
            this.lblSayı1.Location = new System.Drawing.Point(24, 9);
            this.lblSayı1.Name = "lblSayı1";
            this.lblSayı1.Size = new System.Drawing.Size(33, 13);
            this.lblSayı1.TabIndex = 0;
            this.lblSayı1.Text = "Sayı1";
            // 
            // lblSayı2
            // 
            this.lblSayı2.AutoSize = true;
            this.lblSayı2.Location = new System.Drawing.Point(24, 39);
            this.lblSayı2.Name = "lblSayı2";
            this.lblSayı2.Size = new System.Drawing.Size(33, 13);
            this.lblSayı2.TabIndex = 1;
            this.lblSayı2.Text = "Sayı2";
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.Location = new System.Drawing.Point(12, 75);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(73, 25);
            this.lblSonuc.TabIndex = 2;
            this.lblSonuc.Text = "Snucu";
            // 
            // txtSayı1
            // 
            this.txtSayı1.Location = new System.Drawing.Point(64, 6);
            this.txtSayı1.Name = "txtSayı1";
            this.txtSayı1.Size = new System.Drawing.Size(115, 20);
            this.txtSayı1.TabIndex = 3;
            // 
            // txtSayı2
            // 
            this.txtSayı2.Location = new System.Drawing.Point(64, 32);
            this.txtSayı2.Name = "txtSayı2";
            this.txtSayı2.Size = new System.Drawing.Size(115, 20);
            this.txtSayı2.TabIndex = 4;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.Location = new System.Drawing.Point(37, 125);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(142, 48);
            this.btnHesapla.TabIndex = 5;
            this.btnHesapla.Text = "İki sayı topla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 227);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtSayı2);
            this.Controls.Add(this.txtSayı1);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.lblSayı2);
            this.Controls.Add(this.lblSayı1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSayı1;
        private System.Windows.Forms.Label lblSayı2;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.TextBox txtSayı1;
        private System.Windows.Forms.TextBox txtSayı2;
        private System.Windows.Forms.Button btnHesapla;
    }
}

