using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerDomainModel;
using CustomerDAL;

namespace CustomerBusinessLogic
{
   
    public class BusinessLayer : IBusinessLayer
    {
        private readonly ICustomerRepository _custRepository;

        #region "Constructors"

        public BusinessLayer()
        {
            _custRepository = new CustomerRepository();
        }

        public BusinessLayer(ICustomerRepository custRepository)
        {
            _custRepository = custRepository;
        }
        #endregion 

        #region "Methods"

        public IList<Customer> GetAll()
        {
            return _custRepository.GetAll();
        }

        public IList<Customer> GetAllPaged(int pageNumber, int recordCount)
        {
            return _custRepository.GetAllPaged(pageNumber - 1, recordCount, c => c.LastName);
        }

        public int GetTotalRecordCount()
        {
            return _custRepository.GetTotalRecordCount();
        }
        public Customer GetCustomerByID(int ID)
        {
            return _custRepository.GetSingle(c => c.IDNumber.Equals(ID));
        }

        public Customer GetCustomerByName(string customerName)
        {
            return _custRepository.GetSingle(c => c.LastName.Equals(customerName)); 
        }

        public IList<CRUDErrors> AddCustomer(params Customer[] customer)
        {
            _custRepository.Add(customer);
            return _custRepository.GetCRUDErrors();
        }

        public IList<CRUDErrors> UpdateCustomer(params Customer[] customer)
        {
            _custRepository.Update(customer);
            return _custRepository.GetCRUDErrors();
        }

        public IList<CRUDErrors> RemoveCustomer(params Customer[] customer)
        {
            _custRepository.Remove(customer);
            return _custRepository.GetCRUDErrors();
        }
        #endregion
    }
}
