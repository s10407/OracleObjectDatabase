using System;
using System.Collections.Generic;
using System.Text;

namespace OracleObjectDatabase.DAL.Repository
{
    public interface IRepository<T> where T : class
    {
        int Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Detele(int id);
        IEnumerable<T> GetCollection(Func<T, bool> func = null);
        T GetOne(Func<T, bool> func);
    }
}
