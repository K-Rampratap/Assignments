using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment_MVC_Employee.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Assignment_MVC_Employee.Repository;

namespace Assignment_MVC_Employee.Controllers
{
    public class CustomerController : Controller
    {
        public CustomerRepo _repo = new CustomerRepo();

        // GET: CustomerController
        [Route("GetAll")]
        public ActionResult Index()
        {
            List<Customer> cus = _repo.GetCustomers();
            return View(cus);
        }

        // GET: CustomerController/Details/5
        public ActionResult Details(int id)
        {
            Customer c = _repo.GetCustomerByID(id);
            return View(c);
        }

        // GET: CustomerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Customer c)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    _repo.Add(c);
                    return RedirectToAction(nameof(Index));
                }
                else
                    return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id)
        {
            Customer c = _repo.GetCustomerByID(id);
            return View(c);
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Customer c)
        {
            try
            {
                _repo.Update(c);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Delete/5
        public ActionResult Delete(int id)
        {
            Customer c = _repo.GetCustomerByID(id);
            return View(c);
        }

        // POST: CustomerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Customer c)
        {
            try
            {
                _repo.Delete(c);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
