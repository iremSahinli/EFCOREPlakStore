using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plak_DATA.Entity
{
    public class Album
    {
        public int AlbumId { get; set; }
        public string AlbumAdi { get; set; }
        public string Sanatci { get; set; }
        public DateTime CikisTarihi { get; set; }
        public decimal Fiyat { get; set; }
        public double? IndirimOrani { get; set; }
        public bool SatisDurumu { get; set; }

        //Navigation:
        public int AdminId { get; set; }
        public Admin Admin { get; set; }
    }
}
