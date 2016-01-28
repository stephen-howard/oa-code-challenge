using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerDomainModel;

namespace CustomerBusinessLogic
{
    public interface IBusinessLayer
    {
        IList<Customer> GetAll(); // All customers
        IList<Customer> GetAllPaged(int pageNumber, int recordCount); // Paged customers
        int GetTotalRecordCount();
        Customer GetCustomerByName(string customerName);
        Customer GetCustomerByID(int ID);
        IList<CRUDErrors> AddCustomer(params Customer[] customer);
        IList<CRUDErrors> RemoveCustomer(params Customer[] customer);
        IList<CRUDErrors> UpdateCustomer(params Customer[] customer);
    }
}
