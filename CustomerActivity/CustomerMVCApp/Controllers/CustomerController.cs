using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using System.ServiceModel;
using CustomerMVCApp.CustomerServiceClient;
using CustomerLoggerNLog;

namespace CustomerMVCApp.Controllers
{
    public class CustomerController : Controller
    {

        CustomerServiceClient.CustomerServiceClient proxyClient = new CustomerServiceClient.CustomerServiceClient();
      
        public ActionResult Index(int? PageSize, int? page)
        {
            List<Customer> customers = new List<Customer>();
            customers = proxyClient.GetCustomersPaged(page ?? 1, PageSize ?? 10).ToList();
            var count = proxyClient.GetCountOfRecords();
            var resultAsPagedList = new StaticPagedList<Customer>(customers, page ?? 1, PageSize ?? 10, count);

            return View(resultAsPagedList);
        }

        //
        // GET: /Customer/Details/5
        public ActionResult Details(string lastName)
        {
            return View(proxyClient.GetCustomerByName(lastName));
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    proxyClient.AddCustomer(customer);
                    return RedirectToAction("Index");
                }
            }
            catch (FaultException<FaultModelError[]> ff)
            {
                foreach (FaultModelError f in ff.Detail)
                {
                    ModelState.AddModelError(f.PropertyName, f.ErrorMessage);
                    Log.Instance.Warn("Error while adding customer..." + f.PropertyName + f.ErrorMessage);
                }
            }
            return View();
        }

        // GET: /Product/Edit/5
        public ActionResult Edit(string lastName)
        {
            return View(proxyClient.GetCustomerByName(lastName));
        }

        // POST: /Product/Edit/5
        [HttpPost]
        public ActionResult Edit(Customer customer)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    proxyClient.UpdateCustomer(customer);
                    return RedirectToAction("Index");
                }
            }
            catch (FaultException<FaultModelError[]> ff)
            {
                foreach (FaultModelError f in ff.Detail)
                {
                    ModelState.AddModelError(f.PropertyName, f.ErrorMessage);
                    Log.Instance.Warn("Error while Updating customer..." + f.PropertyName + f.ErrorMessage);
                }
            }
            return View();
        }
        
        //
        // GET: /Customer/Delete/5
        public ActionResult Delete(string lastName)
        {
            return View(proxyClient.GetCustomerByName(lastName));
        }

        //
        // POST: /Customer/Delete/5
        [HttpPost]
        public ActionResult Delete(Customer customer)
        {
            try
            {
                proxyClient.DeleteCustomer(customer);
                return RedirectToAction("Index");
            }
        
                catch (FaultException<FaultModelError[]> ff)
            {
                foreach (FaultModelError f in ff.Detail)
                {
                    ModelState.AddModelError("", f.ErrorMessage);
                    Log.Instance.Warn("Error while Updating customer..." + f.PropertyName + f.ErrorMessage);
                }
            }
            return View();
        }
    }
}
