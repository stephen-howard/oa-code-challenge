using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using CustomerDomainModel;
using CustomerBusinessLogic;

namespace CustomerServiceLayer
{
    public class CustomerService : ICustomerService
    {
        public List<Customer> GetAll()
        {
            BusinessLayer bl = new BusinessLayer();
            var customers = from c in bl.GetAll().ToList()
                            select new Customer
                            {
                                LastName = c.LastName,
                                FirstName = c.FirstName,
                                Address = c.Address,
                                PostalCode = c.PostalCode,
                                IDNumber = c.IDNumber
                            };
            return customers.ToList();
        }

        public List<Customer> GetCustomersPaged(int pageNumber, int recordCount)
        {
            BusinessLayer bl = new BusinessLayer();
            var customers = from c in bl.GetAllPaged(pageNumber, recordCount)
                           select new Customer
                          {
                              LastName = c.LastName,
                              FirstName = c.FirstName,
                              Address = c.Address,
                              PostalCode = c.PostalCode,
                              IDNumber = c.IDNumber
                          };
            return customers.ToList();
        }

        public int GetCountOfRecords()
        {
            BusinessLayer bl = new BusinessLayer();
            return bl.GetTotalRecordCount();
        }

        public Customer GetCustomerByID(int ID)
        {
            BusinessLayer bl = new BusinessLayer();
            Customer cust = new Customer();
            var c = bl.GetCustomerByID(ID);
            cust.LastName = c.LastName;
            cust.FirstName = c.FirstName;
            cust.Address = c.Address;
            cust.PostalCode = c.PostalCode;
            cust.IDNumber = c.IDNumber;

            return cust;
        }

        public Customer GetCustomerByName(string customerName)
        {
            BusinessLayer bl = new BusinessLayer();  // Redo like above(to avoid http or service closed error
            Customer cust = new Customer();
            cust = bl.GetCustomerByName(customerName);
            return cust;
        }

        #region "Customer CRUD"

        public void AddCustomer(Customer customer)
        {
            BusinessLayer bl = new BusinessLayer();
            IList<CRUDErrors> errors = bl.AddCustomer(customer);
            throwServiceFaultExceptions(errors);
        }

        public void UpdateCustomer(Customer customer)
        {
            BusinessLayer bl = new BusinessLayer();
            IList<CRUDErrors> errors = bl.UpdateCustomer(customer);
            throwServiceFaultExceptions(errors);
        }

        public void DeleteCustomer(Customer customer)
        {
            BusinessLayer bl = new BusinessLayer();
            IList<CRUDErrors> errors = bl.RemoveCustomer(customer);
            throwServiceFaultExceptions(errors);
            ////show model errors only if the count is greater than 0
            //if (errors.Count() > 0)
            //{
            //    IList<FaultModelError> fm = new List<FaultModelError>();
            //    int i = 0;
            //    foreach (CRUDErrors ee in errors)
            //    {
            //        fm[i] = new FaultModelError { PropertyName = ee.PropertyName, ErrorMessage = ee.ErrorMessage };
            //        i++;
            //    }
            //    throw new FaultException<IList<FaultModelError>>(fm, new FaultReason("Entity Updation Error"));
            //}
        }

        private void throwServiceFaultExceptions(IList<CRUDErrors> errors)
        {
            if (errors != null)
            {
                if (errors.Count() > 0) //show model errors only if the count is greater than 0
                {
                    FaultModelError[] fm = new FaultModelError[errors.Count()];
                    int i = 0;
                    foreach (CRUDErrors ee in errors)
                    {
                        fm[i] = new FaultModelError { PropertyName = ee.PropertyName, ErrorMessage = ee.ErrorMessage };
                        i++;
                    }
                    throw new FaultException<FaultModelError[]>(fm, new FaultReason("Entity Validation Error"));
                }
            }
        }

        #endregion "Customer CRUD"
    }

}

