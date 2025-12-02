using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İşkurExxel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string lavaboNo = txtLavaboNo.Text.Trim();
            string kat = txtKat.Text.Trim();
            string sorun = txtSorun.Text.Trim();

            // Basit doğrulama (boş mu diye kontrol)
            if (string.IsNullOrWhiteSpace(lavaboNo) ||
                string.IsNullOrWhiteSpace(kat) ||
                string.IsNullOrWhiteSpace(sorun))
            {
                MessageBox.Show("Lavabo No, Kat ve Sorun alanlarının hepsi dolu olmalıdır.",
                    "Eksik Bilgi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Şimdilik sadece ekrana gösterelim (kontrol amaçlı)
            MessageBox.Show(
                $"Lavabo No: {lavaboNo}\nKat: {kat}\nSorun: {sorun}",
                "İstek Alındı",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            // İleride bu veriyi bir listeye ekleyip Excel'e aktaracağız.
            // Şimdilik alanları temizleyelim:
            txtLavaboNo.Clear();
            txtKat.Clear();
            txtSorun.Clear();

            txtLavaboNo.Focus();
        }
    }
}
