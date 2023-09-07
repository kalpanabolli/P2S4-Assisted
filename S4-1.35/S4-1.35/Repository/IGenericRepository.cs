using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace S4_1._35.Repository
{
    public interface IGenericRepository<t> where t : class
    {
        IEnumerable<t> SelectAll();
        t SelectByID(object id);
        void Insert(t obj);
        void Update(t obj);
        void Delete(object id);
        void Save();
    }

}