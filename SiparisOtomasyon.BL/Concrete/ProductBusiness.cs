using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisOtomasyon.BL.Concrete
{
    using Abstract;
    using DAL.Context;
    using DAL.Abstract;
    using DAL.Concrete;
    using SiparisOtomasyon.DAL.VM;

    public class ProductBusiness : IProductBusiness
    {
        IProductRepo productRepo;
        public ProductBusiness()
        {
            productRepo = new ProductRepo();
        }
        public void Add(Product item)
        {
            productRepo.Add(item);
        }

        public bool Delete(int id)
        {
            return productRepo.Delete(id);
        }

        public List<Product> Get()
        {
            return productRepo.Get();
        }

        public Product GetById(int id)
        {
            return productRepo.GetById(id);
        }

        public List<ProductVM> GetProductVM()
        {
            return productRepo.GetProductsVM();
        }

        public void Update(Product item)
        {
            productRepo.Update(item);
        }
    }
}
