using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;   
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class YakalaController : Controller
    {
        // GET: Yakala
        public ActionResult Index()
        {
            //View => Controller Veri Aktar

            //1-QueryString üzerinden veri yakalama                                           
            return View();

        }
        public ActionResult Query(string str)
        {
            return Content("Gelen veri" + str);
        }
        //2-Get ile veri yakalama
        public ActionResult YakalaGET()
        {
            Urun urun=new Urun();
            urun.UrunID = int.Parse(Request.QueryString["urunID"]);
            urun.UrunAdi = Request.QueryString[1].ToString();
            urun.Fiyat = decimal.Parse(Request.QueryString[2].ToString());
            return Content("Gelen veri = " + urun.UrunID + " " + urun.Fiyat + " " + urun.UrunAdi);
        }
        public ActionResult Index3()
        {
            //3-Request üzerinden yakala
            return View();

        }
        [HttpPost]
        public ActionResult Index3(string s)
        {
            Urun urun = new Urun();
            urun.UrunID = int.Parse(Request.Form["urunID"]);
            urun.UrunAdi = Request.Form[1].ToString();
            urun.Fiyat = decimal.Parse(Request.Form[2].ToString());
            return Content("POST ile gelen veriyler = " + urun.UrunID + " " + urun.Fiyat + " " + urun.UrunAdi);
        }

        //4-FormCollection üzerinden yakala
        [HttpPost]
        public ActionResult Index4(FormCollection coll)
        {
            Urun urun = new Urun();
            urun.UrunID = int.Parse(coll.Get(0));
            urun.UrunAdi = coll.Get(1).ToString();
            urun.Fiyat = int.Parse(coll.Get(2));
            return Content("POST ile gelen veriyler = " + urun.UrunID + " " + urun.Fiyat + " " + urun.UrunAdi);
        }
        //5-Parametre üzerinden yakalama
        [HttpPost]
        public ActionResult Index5(int urunID, string urunAdi, decimal fiyat)
        {
            return Content("POST ile gelen veriyler = " + urunID + " " + fiyat + " " + urunAdi);
        }

        //6-Model ile yakalama
        [HttpPost]
        public ActionResult Index6(Urun urun)
        {
            return Content("POST ile gelen veriyler = " + urun.UrunID + " " + urun.UrunAdi + " " + urun.Fiyat);
        }
    }
}   