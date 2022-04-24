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

    public interface ICustomerBusiness:IBusiness<Customer,string>
    {

    }
}
