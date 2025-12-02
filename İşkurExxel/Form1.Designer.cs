namespace İşkurExxel
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
            this.lavabono = new System.Windows.Forms.Label();
            this.Kat = new System.Windows.Forms.Label();
            this.Sorun = new System.Windows.Forms.Label();
            this.txtLavaboNo = new System.Windows.Forms.TextBox();
            this.txtKat = new System.Windows.Forms.TextBox();
            this.txtSorun = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lavabono
            // 
            this.lavabono.AutoSize = true;
            this.lavabono.Location = new System.Drawing.Point(325, 98);
            this.lavabono.Name = "lavabono";
            this.lavabono.Size = new System.Drawing.Size(74, 16);
            this.lavabono.TabIndex = 0;
            this.lavabono.Text = "Lavabo No";
            // 
            // Kat
            // 
            this.Kat.AutoSize = true;
            this.Kat.Location = new System.Drawing.Point(325, 139);
            this.Kat.Name = "Kat";
            this.Kat.Size = new System.Drawing.Size(26, 16);
            this.Kat.TabIndex = 1;
            this.Kat.Text = "Kat";
            // 
            // Sorun
            // 
            this.Sorun.AutoSize = true;
            this.Sorun.Location = new System.Drawing.Point(325, 196);
            this.Sorun.Name = "Sorun";
            this.Sorun.Size = new System.Drawing.Size(42, 16);
            this.Sorun.TabIndex = 2;
            this.Sorun.Text = "Sorun";
            // 
            // txtLavaboNo
            // 
            this.txtLavaboNo.Location = new System.Drawing.Point(504, 98);
            this.txtLavaboNo.Name = "txtLavaboNo";
            this.txtLavaboNo.Size = new System.Drawing.Size(100, 22);
            this.txtLavaboNo.TabIndex = 3;
            // 
            // txtKat
            // 
            this.txtKat.Location = new System.Drawing.Point(504, 139);
            this.txtKat.Name = "txtKat";
            this.txtKat.Size = new System.Drawing.Size(100, 22);
            this.txtKat.TabIndex = 4;
            // 
            // txtSorun
            // 
            this.txtSorun.Location = new System.Drawing.Point(504, 167);
            this.txtSorun.Multiline = true;
            this.txtSorun.Name = "txtSorun";
            this.txtSorun.Size = new System.Drawing.Size(250, 80);
            this.txtSorun.TabIndex = 5;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(529, 284);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(126, 23);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "İsteği Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // Form1
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lavabono;
        private System.Windows.Forms.Label Kat;
        private System.Windows.Forms.Label Sorun;
        private System.Windows.Forms.TextBox txtLavaboNo;
        private System.Windows.Forms.TextBox txtKat;
        private System.Windows.Forms.TextBox txtSorun;
        private System.Windows.Forms.Button btnEkle;
    }
}

