using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineTicketSalesSystem
{
    internal class Ticket:abstarct //Bilet
    {
        //Id
        public int PlainId{ get; set; }
        public int RouteId{ get; set; } 
        public double Price { get; set; }
    }
}
