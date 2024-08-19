using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plak_DATA.Entity
{
    public class Admin
    {
        public int AdminId { get; set; }
        public string Ad { get; set; }
        public string Sifre { get; set; }


        //Navigation:
        public IList<Album> Albums { get; set; } //Adminin albümleri vardır.
    }
}
