using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineTicketSalesSystem
{
    internal class customerProcess : Icrud<Customer>
    {
        public bool Add(Customer obj)
        {

            try
            {
                DbContext.CustomerList.Add(obj);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(string tc)
        {
            bool result = false;
            foreach (var customer in DbContext.CustomerList.ToList())
            {
                if (customer.TC == tc)
                {
                    DbContext.CustomerList.Remove(customer);
                    result = true;
                }
            }
            return result;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Customer Detail(int id)
        {
            Customer newCustomer = new Customer();
            foreach (var customer in DbContext.CustomerList.ToList())
            {
                if (customer.Id == id)
                {
                    newCustomer = customer;
                }
            }
            return newCustomer;
        }

        public List<Customer> List()
        {
            return DbContext.CustomerList.ToList();
        }
    }
}
