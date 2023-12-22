using OkulApp.DAL;
using OkulApp.MODEL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace OkulApp.BLL
{
    public class OgretmenBL
    {
        public bool OgretmenKaydet(Ogretmen ogrtmn)
        {
            var hlp = new Helper();
            var p = new SqlParameter[] {
                new SqlParameter("@Ad",ogrtmn.OgrtAd),
                new SqlParameter("@Soyad",ogrtmn.OgrtSoyad),
                new SqlParameter("@TC",ogrtmn.OgrtTCNo)
            };
            return hlp.ExecuteNonQuery("Insert into tlbOgretmenler values(@Ad,@Soyad,@TC)", p) > 0;
        }
    }
}
