using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TravelTripProje.Models.Classes;

namespace TravelTripProje.Models.Classes
{
    public class BlogYorum
    {
        public IEnumerable<Blog> Deger1 { get; set; }
        public IEnumerable<Yorumlar> Deger2 { get; set; }
        public IEnumerable<Blog> Deger3 { get; set; }

        // birden fazla tablodan veri cekmek istedigimizde IEnumerable kullanilir
    }
}