using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository
    {
        // CRUD
        // Type Name();
        // T bir generic typedır.
        List<T> List<T>();

        void Insert<T>(T p);
        void Update<T>(T p);
        void Delete<T>(T p);
    }
}
