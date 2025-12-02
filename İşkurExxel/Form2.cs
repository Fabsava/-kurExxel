using İşkurExxel.Model;
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
    public partial class Form2 : Form
    {
        private List<IstekModel> _istekler;

        public Form2(List<IstekModel> istekler)
        {
            InitializeComponent();
            _istekler = istekler;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string lavabo = txtLavaboNo.Text.Trim();
            string kat = txtKat.Text.Trim();
            string sorun = txtSorun.Text.Trim();

            if (lavabo == "" || kat == "" || sorun == "")
            {
                MessageBox.Show("Tüm alanları doldurmalısın.");
                return;
            }

            _istekler.Add(new IstekModel
            {
                LavaboNo = lavabo,
                Kat = kat,
                Sorun = sorun
            });

            MessageBox.Show("Form2’den istek başarıyla eklendi!");

            this.Close();
        }
    }
}
