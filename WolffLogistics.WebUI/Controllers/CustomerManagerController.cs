using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WolffLogistics.Core.Contracts;
using WolffLogistics.Core.Models;
using WolffLogistics.DataAccess.SQL;

namespace WolffLogistics.WebUI.Controllers
{
    public class CustomerManagerController : Controller
    {
        IRepository<Customer> context;
        // GET: CustomerManager
        public CustomerManagerController(IRepository<Customer> customerContext)
        {
            context = customerContext;
        }
        public ActionResult Index()
        {
            List<Customer> customers = context.Collection().ToList();
            return View(customers);
        }
        public ActionResult Create()
        {
            Customer customer = new Customer();
            return View(customer);
        }
        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                return View(customer);
            }
            else
            {
                context.Insert(customer);
                context.Commit();
                return RedirectToAction("Index");
            }
        }
        public ActionResult Edit(string Id)
        {
            Customer customer = context.Find(Id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(customer);
            }
        }
        [HttpPost]
        public ActionResult Edit(Customer customer, string Id)
        {
            Customer customerToEdit = context.Find(Id);
            if (customerToEdit == null)
            {
                return HttpNotFound();
            }
            else
            {
                if (!ModelState.IsValid)
                {
                    return View(customer);
                }
                customerToEdit.AccountNumber = customer.AccountNumber;
                customerToEdit.City = customer.City;
                customerToEdit.CompanyName = customer.CompanyName;
                customerToEdit.Email = customer.Email;
                customerToEdit.PostalCode = customer.PostalCode;
                customerToEdit.Province = customer.Province;
                customerToEdit.RegistrationNumber = customer.RegistrationNumber;
                customerToEdit.Street = customer.Street;
                customerToEdit.TelephoneNumber = customer.TelephoneNumber;
                customerToEdit.VatNumber = customer.VatNumber;

                context.Commit();
                return RedirectToAction("Index");
            }
        }
        public ActionResult Delete(string Id)
        {
            Customer customerToDelete = context.Find(Id);
            if (customerToDelete == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(customerToDelete);
            }
        }
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult ConfirmDelete(string Id)
        {
            Customer customerToDelete = context.Find(Id);
            if (customerToDelete == null)
            {
                return HttpNotFound();
            }
            else
            {
                context.Delete(Id);
                context.Commit();
                return RedirectToAction("Index");
            }
        }
    }
}