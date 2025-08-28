using System.Globalization;
using ProductAPI.Model;
using ProductAPI.Profiles;

namespace ProductAPI.Data
{
    public class CustomerRepo
    {
        private companyDBContext compDB;

        public CustomerRepo(companyDBContext context)
        {
            compDB = context;
        }

        public bool SaveCustomer()
        {
            int count = compDB.SaveChanges();
            return count > 0;
        }

        public bool CreateNewCustomer(Customer customer)
        {
            if (customer != null)
            {
                compDB.CustomerInfo.Add(customer);
                return SaveCustomer();
            }
            return false;
        }

        public bool UpdateCustomer(Customer customer)
        {
            if (customer != null)
            {
                compDB.CustomerInfo.Update(customer);
                return SaveCustomer();
            }
            return false;
        }

        public bool DeleteCustomer(Customer customer)
        {
            if (customer != null)
            {
                compDB.CustomerInfo.Remove(customer);
                return SaveCustomer();
            }
            return false;
        }

        public Customer GetCustomer(string cname, string pass)
        {
            return compDB.CustomerInfo.FirstOrDefault(cus => cus.Cusemail == cname && cus.CusPassword == pass);
        }

        public IEnumerable<Customer> GetAllCustomer()
        {
            return compDB.CustomerInfo.ToList();
        }
    }
}