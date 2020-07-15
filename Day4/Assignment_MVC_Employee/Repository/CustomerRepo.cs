using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment_MVC_Employee.Entities;

namespace Assignment_MVC_Employee.Repository
{
    public class CustomerRepo
    {
        public CustomerContext db = new CustomerContext();
        public List<Customer> GetCustomers()
        {
            return db.Customers.ToList(); 
        }
        public Customer GetCustomerByID(int eid)
        {
            return db.Customers.Find(eid);
        }

        public void Add(Customer e)
        {
            db.Customers.Add(e); 
            db.SaveChanges();
        }
        public void Delete(Customer e)
        {
            db.Customers.Remove(e); 
            db.SaveChanges();
        }
        public void Update(Customer e)
        {
            db.Customers.Update(e); 
            db.SaveChanges();
        }
    }
}
