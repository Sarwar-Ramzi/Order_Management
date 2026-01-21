using Microsoft.AspNetCore.Mvc;
using OM_Web.Data;
using OM_Web.Models;


namespace OM_Web.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CustomerController(ApplicationDbContext db)
        {
            _db = db;
        }


        public IActionResult Index()
        {
            List<Customer> objCustomerList = _db.Customers.ToList();
            return View(objCustomerList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Customer obj)
        {

            if (ModelState.IsValid)
            {
                _db.Customers.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Customer created successfully";
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Update(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var customerFromDb = _db.Customers.Find(id);
            if (customerFromDb == null)
            {
                return NotFound();
            }
            return View(customerFromDb);
        }

        [HttpPost]
        public IActionResult Update(Customer obj)
        {
            //--------The below code is for testing ModelState.AddModelError--------------------
            if (obj.Company != null && obj.Company.Contains("^"))
            {
                ModelState.AddModelError("Company", "Customer Name must not have '^' character");
            }
            if (obj.Company != null && obj.Company.ToLower()=="test")
            {
                ModelState.AddModelError("", "Hello Error!");
            }
            //-----------------------------------------------------------------------------------
            if (ModelState.IsValid)
            {
                _db.Customers.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "Customer updated successfully";
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var customerFromDb = _db.Customers.Find(id);
            if (customerFromDb == null)
            {
                return NotFound();
            }
            return View(customerFromDb);
        }
        [HttpPost]
        public IActionResult Delete(Customer obj)
        {
            if (obj == null)
            {
                return NotFound();
            }

            _db.Customers.Remove(obj);
            _db.SaveChanges();
            TempData["success"] = "Customer deleted successfully";
            return RedirectToAction("Index");
        }
    }

}
