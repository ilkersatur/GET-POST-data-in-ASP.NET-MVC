using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Fatura_VM
    {
        public string Musteri { get; set; }
        public decimal ToplamTutar { get; set; }    
        public DateTime FaturaKesimTarihi { get; set; }

        public List<FaturaDetay> FaturaDetay { get; set; }
    }
}