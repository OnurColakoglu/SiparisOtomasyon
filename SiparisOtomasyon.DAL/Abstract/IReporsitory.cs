using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisOtomasyon.DAL.Abstract
{
    public interface IReporsitory<T,T1>
    {
        void Add(T item);
        void Update(T item);
        bool Delete(T1 Id);
        List<T> Get();
        T GetById(T1 Id);

    }
}
