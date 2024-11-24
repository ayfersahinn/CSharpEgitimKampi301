using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccessLayer.Abstract
{
    public interface IGenericDal <T> where T : class
    {
        void insert(T entity);
        void delete(T entity);
        void update(int id);
        List<T> GetAll();
        T GetById(int id);
    }
}
