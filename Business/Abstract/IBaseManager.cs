using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIOGün2Ödev3.Business.Abstract
{
    public interface IBaseManager<T> where T : class
    {
        List<T> GetAll();
        void Add(T entity);
        void Update(T entity);
        T Delete(T entity);
    }
}
