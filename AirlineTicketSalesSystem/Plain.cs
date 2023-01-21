using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineTicketSalesSystem
{
    internal class Plain : abstarct
    {
        //Id
        public int RouteID { get; set; }   // gidiş dönüş yönü
        public int seatPiece { get; set; }  // koltuk stok
        public string DepertureTime { get; set; } //kalkış saati
        public double Price { get;set; } // Uçak Bilet Fiyat
    }
}
