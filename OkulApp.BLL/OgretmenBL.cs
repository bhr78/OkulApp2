using DAL;
using OkulApp.BLL;
using OkulApp.MODEL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;


namespace OkulApp.BLL
{
    public class OgretmenBL
    {
        private Helper hlp;
        public OgretmenBL()
        {
            hlp = Helper.GetInstance;
        }
        public bool OgretmenEkle(Ogretmen ogrt)
        {
            try
            {
                SqlParameter[] p = {
                             new SqlParameter("@Ad",ogrt.Ad),
                             new SqlParameter("@Soyad",ogrt.Soyad),
                             new SqlParameter("@TCkimlik",ogrt.TCkimlik)
                         };
                //var hlp = new Helper();
                return hlp.ExecuteNonQuery("Insert into tblOgretmenlerr values(@Ad, @Soyad, @TCkimlik)", p) > 0;
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            finally 
            { 
            }
        } 
        public Ogretmen OgretmenBul(string TCkimlik)
        {
            //var hlp = new Helper();
            try
            {
                SqlParameter[] p = { new SqlParameter("@TCkimlik", TCkimlik) };
                var dr = hlp.ExecuteReader("Select OgretmenID,Ad,Soyad,TCkimlik from tblOgretmenlerr where TCkimlik=@TCkimlik", p);
                Ogretmen ogrt = null;
                if (dr.Read())
                {
                    ogrt = new Ogretmen();
                    ogrt.Ad = dr["Ad"].ToString();
                    ogrt.Soyad = dr["Soyad"].ToString();
                    ogrt.TCkimlik = dr["TCkimlik"].ToString();
                    ogrt.OgretmenID = Convert.ToInt32(dr["OgretmenID"]);
                }
                dr.Close();
                return ogrt;
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
        public bool OgretmenSil(int OgretmenID)
        {
            try
            {
                //var hlp = new Helper();
                SqlParameter[] p = { new SqlParameter("@OgretmenID", OgretmenID) };
                return hlp.ExecuteNonQuery("Delete from tblOgretmenlerr where OgretmenID=@OgretmenID", p) > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool OgretmenGuncelle(Ogretmen ogrt)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@Ad",ogrt.Ad),
                new SqlParameter("@Soyad",ogrt.Soyad),
                new SqlParameter("@TCKimlik", ogrt.TCkimlik),
                new SqlParameter("@OgretmenID",ogrt.OgretmenID)};
                //var hlp = new Helper();
                return hlp.ExecuteNonQuery("Update tblOgretmenlerr set Ad=@Ad,Soyad=@Soyad,TCkimlik=@TCkimlik where OgretmenID=@OgretmenID", p) > 0;
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
   
















