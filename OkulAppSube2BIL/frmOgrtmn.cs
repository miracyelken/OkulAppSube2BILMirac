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

namespace OkulAppSube2BIL
{
    public partial class frmOgrtmn : Form
    {
        public frmOgrtmn()
        {
            InitializeComponent();
        }

        private void btnOgrtKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                var ogrtbl = new OgretmenBL();
                bool sonuc = ogrtbl.OgretmenKaydet(new Ogretmen { OgrtAd = txtOgrtAd.Text.Trim(), OgrtSoyad = txtOgrtSoyad.Text.Trim(), OgrtTCNo = txtOgrtTC.Text.Trim() });
                MessageBox.Show(sonuc ? "Ekleme Başarılı" : "Ekleme Başarısız!!");
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 2627:
                        MessageBox.Show("Bu numara daha önce kaydedilmiş");
                        break;
                    default:
                        MessageBox.Show("Veritabanı Hatası!");
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bilinmeyen Hata!!");
            }
        }
    }


    
}
