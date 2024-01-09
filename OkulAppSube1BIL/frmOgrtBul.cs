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
    public partial class frmOgrtBul : Form
    {
        frmOgrtKayit frm;
        public frmOgrtBul(frmOgrtKayit frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private void btnArat_Click(object sender, EventArgs e)
        {
            try
            {
                OgretmenBL obl = new OgretmenBL();
                Ogretmen ogrt = obl.OgretmenBul(txtNumarat.Text.Trim());
                if (ogrt != null)
                {
                    frm.txtAdt.Text = ogrt.Ad;
                    frm.txtSoyadt.Text = ogrt.Soyad;
                    frm.txtTCkimlikt.Text = ogrt.TCkimlik;
                    frm.OgretmenID = ogrt.OgretmenID;

                    this.Close();
                    frm.btnSilt.Enabled = true;
                    frm.btnGuncellet.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Öğretmen bulunamadı!!");
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
