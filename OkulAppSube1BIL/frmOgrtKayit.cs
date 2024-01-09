using OkulApp.BLL;
using OkulApp.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulAppSube1BIL
{
    public partial class frmOgrtKayit : Form
    {
        public int OgretmenID { get; set; }

        public frmOgrtKayit()
        {
            InitializeComponent();
        }

        private void btnKaydett_Click(object sender, EventArgs e)
        {
            try
            {
                var obl = new OgretmenBL();
                bool sonuc = obl.OgretmenEkle(new Ogretmen { Ad = txtAdt.Text.Trim(), Soyad = txtSoyadt.Text.Trim(), TCkimlik = txtTCkimlikt.Text.Trim() });
                MessageBox.Show(sonuc ? "Ekleme Başarılı!" : "Ekleme Başarısız!!");
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 2627:
                        MessageBox.Show("Bu tc kimlikli öğretmen daha önce kayıtlı");
                        break;
                    default:
                        MessageBox.Show("Veritabanı hatası");
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bilinmeyen Hata!!");
            }
        }

        private void btnBult_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new frmOgrtBul(this);
                frm.Show();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnSilt_Click(object sender, EventArgs e)
        {
            try
            {
                var obl = new OgretmenBL();
                MessageBox.Show(obl.OgretmenSil(OgretmenID) ? "Silme Başarılı" : "Başarısız!");
                // Mevcut kayıdı sildikten sonra da textboxları temizler
                txtAdt.Clear();
                txtSoyadt.Clear();
                txtTCkimlikt.Clear();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnGuncellet_Click(object sender, EventArgs e)
        {
            try
            {
                var obl = new OgretmenBL();
                MessageBox.Show(obl.OgretmenGuncelle(new Ogretmen { Ad = txtAdt.Text.Trim(), Soyad = txtSoyadt.Text.Trim(), TCkimlik = txtTCkimlikt.Text.Trim(), OgretmenID = OgretmenID }) ? "Güncelleme Başarılı" : "Güncelleme Başarısız!");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }

   
}




   