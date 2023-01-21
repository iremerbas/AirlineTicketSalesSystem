using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineTicketSalesSystem
{
    internal class RouteProcess : Icrud<Route>
    {
        public bool Add(Route obj)
        {
            try
            {
                DbContext.RouteList.Add(obj);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(string tc)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            bool result = false;
            foreach (var route in DbContext.RouteList.ToList())
            {
                if (route.Id == id)
                {
                    DbContext.RouteList.Remove(route);
                    result = true;
                }
            }
            return result;
        }

        public Route Detail(int id)
        {
            Route newRoute = new Route();
            foreach (var route in DbContext.RouteList.ToList())
            {
                if (route.Id == id)
                {
                    newRoute = route;
                }
            }
            return newRoute;
        }

        public List<Route> List()
        {

            return DbContext.RouteList.ToList();
        }
    }
}
