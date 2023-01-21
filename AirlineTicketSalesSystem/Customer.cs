using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineTicketSalesSystem
{
    internal class Customer : abstarct
    {
        //Id
        //Name
        public string Surname { get; set; }
        public string TC { get; set; }
        public double Balance { get; set; }
        public bool OpenClose { get; set; }
        
    }
}
