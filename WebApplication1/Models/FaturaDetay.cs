using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class FaturaDetay
    {
        public int FDID { get; set; }
        public int FaturaID { get; set; }
        public int UrunID { get; set; }
        public int Adet { get; set; }
        public decimal Fiyat { get; set; }
    }
}