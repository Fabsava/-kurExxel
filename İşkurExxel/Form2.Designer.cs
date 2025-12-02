namespace İşkurExxel
{
    partial class Form2
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtSorun = new System.Windows.Forms.TextBox();
            this.txtKat = new System.Windows.Forms.TextBox();
            this.txtLavaboNo = new System.Windows.Forms.TextBox();
            this.Sorun = new System.Windows.Forms.Label();
            this.Kat = new System.Windows.Forms.Label();
            this.lavabono = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(365, 306);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(126, 23);
            this.btnEkle.TabIndex = 14;
            this.btnEkle.Text = "İsteği Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtSorun
            // 
            this.txtSorun.Location = new System.Drawing.Point(365, 190);
            this.txtSorun.Multiline = true;
            this.txtSorun.Name = "txtSorun";
            this.txtSorun.Size = new System.Drawing.Size(250, 80);
            this.txtSorun.TabIndex = 13;
            // 
            // txtKat
            // 
            this.txtKat.Location = new System.Drawing.Point(365, 162);
            this.txtKat.Name = "txtKat";
            this.txtKat.Size = new System.Drawing.Size(100, 22);
            this.txtKat.TabIndex = 12;
            // 
            // txtLavaboNo
            // 
            this.txtLavaboNo.Location = new System.Drawing.Point(365, 121);
            this.txtLavaboNo.Name = "txtLavaboNo";
            this.txtLavaboNo.Size = new System.Drawing.Size(100, 22);
            this.txtLavaboNo.TabIndex = 11;
            // 
            // Sorun
            // 
            this.Sorun.AutoSize = true;
            this.Sorun.Location = new System.Drawing.Point(186, 219);
            this.Sorun.Name = "Sorun";
            this.Sorun.Size = new System.Drawing.Size(42, 16);
            this.Sorun.TabIndex = 10;
            this.Sorun.Text = "Sorun";
            // 
            // Kat
            // 
            this.Kat.AutoSize = true;
            this.Kat.Location = new System.Drawing.Point(186, 162);
            this.Kat.Name = "Kat";
            this.Kat.Size = new System.Drawing.Size(26, 16);
            this.Kat.TabIndex = 9;
            this.Kat.Text = "Kat";
            // 
            // lavabono
            // 
            this.lavabono.AutoSize = true;
            this.lavabono.Location = new System.Drawing.Point(186, 121);
            this.lavabono.Name = "lavabono";
            this.lavabono.Size = new System.Drawing.Size(74, 16);
            this.lavabono.TabIndex = 8;
            this.lavabono.Text = "Lavabo No";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtSorun);
            this.Controls.Add(this.txtKat);
            this.Controls.Add(this.txtLavaboNo);
            this.Controls.Add(this.Sorun);
            this.Controls.Add(this.Kat);
            this.Controls.Add(this.lavabono);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtSorun;
        private System.Windows.Forms.TextBox txtKat;
        private System.Windows.Forms.TextBox txtLavaboNo;
        private System.Windows.Forms.Label Sorun;
        private System.Windows.Forms.Label Kat;
        private System.Windows.Forms.Label lavabono;
    }
}