using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineTicketSalesSystem
{
    internal class User : abstarct
    {
        //Id
        //Name
        public string Surname { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool OpenClose { get; set; }
        public double Balance { get; set; }
    }
}
