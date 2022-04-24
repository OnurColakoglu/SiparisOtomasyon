using SiparisOtomasyon.DAL.Abstract;
using SiparisOtomasyon.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisOtomasyon.DAL.Concrete
{
    public class CustomerRepo : ICustomerRepo
    {
        private NorthwndContext DB;
        public CustomerRepo()
        {
            DB = new NorthwndContext();
        }
        public void Add(Customer item)
        {
            DB.Customers.Add(item);
            DB.SaveChanges(); //SaveChanges değişikliği onayla (yaptığım işlemleri veritabınında onayla demek.Her işlemde yapılması gerekmekte)
        }

        public bool Delete(string Id)
        {
            var dbItem = DB.Customers.FirstOrDefault(t0 => t0.CustomerID == Id);
            if (dbItem!=null)
            {
                DB.Customers.Remove(dbItem);
                DB.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Customer> Get()
        {
            var result=  DB.Customers.AsNoTracking().ToList();
            return result;
        }

        public Customer GetById(string Id)
        {
            var result= DB.Customers.AsNoTracking().FirstOrDefault(t0 => t0.CustomerID == Id);
            return result;
        }

        public void Update(Customer item)
        {
            DB.Entry(item).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();
        }
    }
}
