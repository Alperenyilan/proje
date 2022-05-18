using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace Proje.Web
{
    public partial class Test2 : System.Web.UI.Page
    {
       static public List<Proje.Business.OgrBilgi> OgrListesi = new List<Business.OgrBilgi>();
        protected void Page_Load(object sender, EventArgs e)
        {
            int[] sayilar = new int[] { 1, 2, 4, 5, 7, 9 };
            //QUERY
            var sonuc = from sayi in sayilar where sayi>5 select sayi;
            //foreach (var item in sonuc)
            //{
            //    lst.Items.Add(item.ToString());
            //}
            //Method ile
            List<int> sonuc1 = sayilar.Where(p => p > 5).ToList();
            foreach (var item in sonuc1)
            {
                lst.Items.Add(item.ToString());
            }

      

            for (int i = 0; i < 3; i++)
            {
                Proje.Business.OgrBilgi ogrenci = new Business.OgrBilgi();
                ogrenci.OgrAd = (i + 1).ToString() + " Öğrenci";
                ogrenci.OgrNo = new Random().Next().ToString();
                ogrenci.OgrTcNo = "999999999-" + i;
                OgrListesi.Add(ogrenci);

            }


            //OgrListesi.Add(new Business.OgrBilgi { OgrAd = "", OgrNo = "", OgrTcNo = "" });








        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            List<Proje.Business.OgrBilgi> sonuc = OgrListesi.Where(y => y.OgrAd == "2. Öğrenci").ToList();


            //SqlConnection baglan = new SqlConnection("Data Source=GUNCELSARIMAN;Initial Catalog=WebProgramlama;Integrated Security=True");
            string isim= System.Web.Configuration.WebConfigurationManager.ConnectionStrings["baglanti"].ConnectionString;
            SqlConnection baglan = new SqlConnection(isim);
            baglan.Open();
        }
    }
}