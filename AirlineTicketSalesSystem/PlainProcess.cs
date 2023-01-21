using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineTicketSalesSystem
{
    internal class PlainProcess : Icrud<Plain>
    {
        public bool Add(Plain obj)
        {
            try
            {
                DbContext.PlainList.Add(obj);
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
            foreach (var plain in DbContext.PlainList.ToList())
            {
                if (plain.Id == id)
                {
                    DbContext.PlainList.Remove(plain);
                    result = true;
                }
            }
            return result;
        }

        public Plain Detail(int id)
        {
            Plain newPlain = new Plain();
            foreach (var plain in DbContext.PlainList.ToList())
            {
                if (plain.Id == id)
                {
                    newPlain = plain;
                }
            }
            return newPlain;
        }

        public List<Plain> List()
        {

            return DbContext.PlainList.ToList();
        }
    }
}
