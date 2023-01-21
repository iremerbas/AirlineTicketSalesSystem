using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineTicketSalesSystem
{
    interface Icrud<T>
    {
        bool Add(T obj);
        bool Delete(string tc);
        bool Delete(int id);
        T Detail(int id);
        List<T> List();
    }
}
