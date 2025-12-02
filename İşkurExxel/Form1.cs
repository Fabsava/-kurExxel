using ClosedXML.Excel;
using İşkurExxel.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Core;
using System.IO;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using OfficeOpenXml;
namespace İşkurExxel
{
    public partial class Form1 : Form
    {
        List<IstekModel> istekler = new List<IstekModel>();
        string selectedImagePath = "";
        public Form1()
        {
            InitializeComponent();
            cmbTip.SelectedIndexChanged += cmbTip_SelectedIndexChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (cmbTip.SelectedItem?.ToString() == "Lavabo")
            {
                txtLavaboNo.Enabled = true;
            }
            else
            {
                txtLavaboNo.Enabled = false;
                txtLavaboNo.Text = "";
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string tip = cmbTip.SelectedItem?.ToString();
            string lavabo = txtLavaboNo.Text.Trim();
            string kat = txtKat.Text.Trim();
            string sorun = txtSorun.Text.Trim();

            // tip seçilmemişse
            if (string.IsNullOrWhiteSpace(tip))
            {
                MessageBox.Show("Lütfen Lavabo mı Sınıf mı seç.", "Hata");
                return;
            }

            // lavabo ise lavabo no zorunlu
            if (tip == "Lavabo" && string.IsNullOrWhiteSpace(lavabo))
            {
                MessageBox.Show("Lavabo seçtiğin için Lavabo No boş olamaz!", "Hata");
                return;
            }

            // sınıf ise lavabo no boş olmalı
            if (tip == "Sınıf")
                lavabo = ""; // otomatik temizle

           

            istekler.Add(new IstekModel
            {
                Tip = tip,
                LavaboNo = lavabo,
                Kat = kat,
                Sorun = sorun,
                ImagePath = selectedImagePath
            });

            MessageBox.Show("İstek eklendi!");

            // temizle
            cmbTip.SelectedIndex = -1;
            txtLavaboNo.Clear();
            txtKat.Clear();
            txtSorun.Clear();
            pictureBox.Image = null;
            selectedImagePath = "";
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;


            using (var package = new ExcelPackage())
            {
                var ws = package.Workbook.Worksheets.Add("İstekler");

                // Başlıklar
                ws.Cells["A1"].Value = "Tip";
                ws.Cells["B1"].Value = "Lavabo No";
                ws.Cells["C1"].Value = "Kat";
                ws.Cells["D1"].Value = "Sorun";
                ws.Cells["E1"].Value = "Resim";

                using (var header = ws.Cells["A1:E1"])
                {
                    header.Style.Font.Bold = true;
                    header.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    header.Style.Fill.BackgroundColor.SetColor(Color.Orange);
                    header.Style.Font.Color.SetColor(Color.White);
                    header.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                }

                int row = 2;

                foreach (var item in istekler)
                {
                    ws.Cells[row, 1].Value = item.Tip;
                    ws.Cells[row, 2].Value = item.LavaboNo;
                    ws.Cells[row, 3].Value = item.Kat;
                    ws.Cells[row, 4].Value = item.Sorun;

                    // Yazıları ortala
                    ws.Cells[row, 1, row, 4].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                    ws.Cells[row, 1, row, 4].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                    int colIndex = 5;

                    // Thumbnail hücresini oluştur
                    ws.Column(colIndex).Width = 9.22;        // Tam thumbnail genişliği
                    ws.Row(row).Height = 50;                 // Tam thumbnail yüksekliği

                    if (File.Exists(item.ImagePath))
                    {
                        var pic = ws.Drawings.AddPicture($"img{row}", new FileInfo(item.ImagePath));

                        // Önce resmi 50x50 içine sığdır
                        pic.SetSize(50, 50);

                        // Hücreyi al
                        var cell = ws.Cells[row, colIndex];

                        // Hücre içindeki tam merkez pozisyonu hesapla
                        int cellPixelX = cell.Start.Column * 64;
                        int cellPixelY = (row - 1) * 20;

                        // Ortalamak için küçük offset
                        int offsetX = 5;
                        int offsetY = 2;

                        // Resmi hücrenin içine konumlandır
                        pic.SetPosition(row - 1, offsetY, colIndex - 1, offsetX);
                    }

                    row++;
                }


                // Kenarlıklar
                using (var rng = ws.Cells[1, 1, row - 1, 5])
                {
                    rng.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                    rng.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                    rng.Style.Border.Right.Style = ExcelBorderStyle.Thin;
                    rng.Style.Border.Top.Style = ExcelBorderStyle.Thin;
                    rng.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                }

                ws.Cells.AutoFitColumns(10);

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel Dosyası|*.xlsx";
                sfd.FileName = "modern_thumbnail.xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(sfd.FileName, package.GetAsByteArray());
                    MessageBox.Show("Modern resimli Excel oluşturuldu!");
                }
            }
        }


        private void cmbTip_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTip.SelectedItem?.ToString() == "Lavabo")
            {
                txtLavaboNo.Enabled = true;
            }
            else
            {
                txtLavaboNo.Enabled = false;
                txtLavaboNo.Text = "";
            }
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = ofd.FileName;
                pictureBox.Image = Image.FromFile(selectedImagePath);
            }
        }
    }
}
