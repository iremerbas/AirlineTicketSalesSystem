using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineTicketSalesSystem
{
    internal class Route : abstarct //Güzergah
    {
        //Id
        public string startPoint { get; set; } //nereden
        public string endPoint { get; set; }   //nereye      
    }
}
