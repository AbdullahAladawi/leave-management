using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leave_management.Contracts
{
   public interface IRepositoryBase<T> where T:class
    {
        ICollection<T> FindAll();
        T FindById(int i);
        bool Create(T entity);
        bool Delete(T entity);
        bool Update(T entity);
        bool save();
    }
}
