using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;


namespace WebApplication1.Controllers
{
    public class GonderController : Controller
    {
        // GET: Gonder
        public ActionResult Index()
        {
            //Controller => View veri aktarma
            //1-ViewData
            //2-ViewBag
            //3-TempData
            //4-Model
            //5-ViewModel
            TempData["veri"] = "Saklı veri"; //bir kere kullanılan veri, sonra ramden silinir. Aksiyonlar arasında veri aktarımında kullanılabilir.
            TempData.Keep();//.Keep() Veriyi tutmak için kullanılır
            return View();
        }
        public ActionResult SakliVeri()
        {
            return Content(TempData["veri"].ToString());
        }
        public ActionResult UrunGoster()
        {
            Urun urun = new Urun() { Fiyat=150,UrunAdi="Pusula",UrunID=1};
            return View(urun);
        }
        public ActionResult TumUrunler()
        {
            List<Urun> urunList = new List<Urun>() {
                new Urun { Fiyat=1,UrunAdi="Atlas",UrunID=4},
                new Urun { Fiyat=3,UrunAdi="Pusula",UrunID=45},
                new Urun { Fiyat=4,UrunAdi="Defter",UrunID=7},};

            return View(urunList);
        }
        public ActionResult FaturaGoster()
        {
            Fatura_VM fatura = new Fatura_VM() ;
            fatura.Musteri = "Cevdet";//Musteriler tablosundan gelecek
            fatura.ToplamTutar = 1000;
            fatura.FaturaKesimTarihi = DateTime.Now;

            fatura.FaturaDetay = new List<FaturaDetay>() {
                new FaturaDetay{UrunID=1,FaturaID=23,Adet=4,Fiyat=24 },
                new FaturaDetay{UrunID=3,FaturaID=43,Adet=3,Fiyat=244  },
                new FaturaDetay{UrunID=6,FaturaID=27,Adet=9,Fiyat=345  } };
            return View(fatura);  //view ile modeli html sayfasına gönder 
        }
    }
}