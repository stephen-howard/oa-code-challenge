using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using CustomerDomainModel;

namespace CustomerDAL
{
    public interface IGenericDataRepository<T> where T : class
    {
        IList<T> GetAll(params Expression<Func<T, object>>[] navigationProperties);
        IList<T> GetAllPaged(int pageNumber, int recordCount, Expression<Func<T, string>> orderBy, params Expression<Func<T, object>>[] navigationProperties);
        IList<T> GetList(Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties);
        T GetSingle(Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties);
        void Add(params T[] items);
        void Update(params T[] items);
        void Remove(params T[] items);
        int GetTotalRecordCount();
        IList<CRUDErrors> GetCRUDErrors();
    }

    public interface ICustomerRepository : IGenericDataRepository<Customer>
    {
    }

    public class CustomerRepository : GenericDataRepository<Customer>, ICustomerRepository
    {
    }
  
}
