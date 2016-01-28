using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using CustomerBusinessLogic;
using CustomerDomainModel;

namespace CustomerServiceLayer
{
        // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
   [ServiceContract]
    public interface ICustomerService
    {

        [OperationContract]
        List<Customer> GetAll();

        [OperationContract]
        int GetCountOfRecords();

        #region "Customer"

        [OperationContract]
        List<Customer> GetCustomersPaged(int pageNumber, int recordCount);

        [OperationContract]
        Customer GetCustomerByID(int ID);

        [OperationContract]
        Customer GetCustomerByName(string customerName);

        [OperationContract]
        [FaultContract(typeof(FaultModelError[]))]
        void AddCustomer(Customer customer);

        [OperationContract]
        [FaultContract(typeof(FaultModelError[]))]
        void UpdateCustomer(Customer customer);

        [OperationContract]
        [FaultContract(typeof(FaultModelError[]))]
        void DeleteCustomer(Customer customer);

        #endregion "Customer"
    }

    [DataContract]
    public class FaultModelError
    {
        public FaultModelError()
        {
            
        }

        public FaultModelError(string p, string e)
        {
            this.PropertyName = p;
            this.ErrorMessage = e;
        }

        [DataMember]
        public string PropertyName = null;

        [DataMember]
        public string ErrorMessage = null;
    }

   
}

