using OkulApp.BLL;
using OkulApp.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulAppSube1BIL
{
    public partial class frmOgrBul : Form
    {
        frmOgrKayit frm;
        public frmOgrBul(frmOgrKayit frm)
        {
            InitializeComponent();
        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            try
            {
                OgrenciBL obl = new OgrenciBL();
                Ogrenci ogr = obl.OgrenciBul(txtNumara.Text.Trim());
                if (ogr != null)
                {
                    frm.txtAd.Text = ogr.Ad;
                    frm.txtSoyad.Text = ogr.Soyad;
                    frm.txtNumara.Text = ogr.Numara;
                    frm.OgrenciId = ogr.OgrenciId;

                    this.Close();
                    frm.btnSil.Enabled = true;
                    frm.btnGuncelle.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Öğrenci bulunamadı!!");
                }
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }
      
    }
}

