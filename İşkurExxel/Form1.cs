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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtLavaboNo.Enabled = true;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string lavabo = txtLavaboNo.Text.Trim();
            string kat = txtKat.Text.Trim();
            string sorun = txtSorun.Text.Trim();

            if (string.IsNullOrWhiteSpace(lavabo))
            {
                MessageBox.Show("Lavabo No boş olamaz!", "Hata");
                return;
            }

            istekler.Add(new IstekModel
            {
                LavaboNo = lavabo,
                Kat = kat,
                Sorun = sorun,
            });

            MessageBox.Show("İstek eklendi!");

            txtLavaboNo.Clear();
            txtKat.Clear();
            txtSorun.Clear();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (var package = new ExcelPackage())
            {
                var ws = package.Workbook.Worksheets.Add("İstekler");

                // ============================
                //  🔥 BAŞLIK EKLEME
                // ============================
                ws.Cells["A1"].Value = "Samsun Üniversitesi Lavabo Sorunları";

                // Başlık tasarım
                using (var title = ws.Cells["A1:C1"])
                {
                    title.Merge = true;
                    title.Style.Font.Size = 18;
                    title.Style.Font.Bold = true;
                    title.Style.Font.Color.SetColor(Color.DarkBlue);
                    title.Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                    title.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                }

                ws.Row(1).Height = 40;  // Başlık satırı yüksekliği

                // Başlık ile tablo arasında boşluk
                ws.Row(2).Height = 15;

                // ============================
                //  🔥 TABLO BAŞLIKLARI
                // ============================
                ws.Cells["A3"].Value = "Lavabo No";
                ws.Cells["B3"].Value = "Kat";
                ws.Cells["C3"].Value = "Sorun";

                using (var header = ws.Cells["A3:C3"])
                {
                    header.Style.Font.Bold = true;
                    header.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    header.Style.Fill.BackgroundColor.SetColor(Color.Orange);
                    header.Style.Font.Color.SetColor(Color.White);
                    header.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                }

                int row = 4;

                foreach (var item in istekler)
                {
                    ws.Cells[row, 1].Value = item.LavaboNo;
                    ws.Cells[row, 2].Value = item.Kat;
                    ws.Cells[row, 3].Value = item.Sorun;

                    ws.Cells[row, 1, row, 3].Style.HorizontalAlignment =
                        ExcelHorizontalAlignment.Center;
                    ws.Cells[row, 1, row, 3].Style.VerticalAlignment =
                        ExcelVerticalAlignment.Center;

                    ws.Row(row).Height = 30;

                    row++;
                }

                // Kenarlık
                using (var rng = ws.Cells[3, 1, row - 1, 3])
                {
                    rng.Style.Border.BorderAround(ExcelBorderStyle.Thin);
                    rng.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                    rng.Style.Border.Right.Style = ExcelBorderStyle.Thin;
                    rng.Style.Border.Top.Style = ExcelBorderStyle.Thin;
                    rng.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                }

                // Tüm sütun genişliklerini uygun hizaya getir
                ws.Cells.AutoFitColumns();

                // İstersen tabloyu ortalayayım (başlığa göre)
                ws.Column(1).Width += 5;

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel Dosyası|*.xlsx";
                sfd.FileName = "istekler.xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(sfd.FileName, package.GetAsByteArray());
                    MessageBox.Show("Excel başarıyla oluşturuldu!");
                }
            }
        }



    }
}
