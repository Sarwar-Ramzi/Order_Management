using Microsoft.AspNetCore.Mvc;
using OM_Web.Data;
using OM_Web.Models;

namespace OM_Web.Controllers
{
    public class OrderController : Controller
    {
        private readonly ApplicationDbContext _db;

        public OrderController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<Order> objOrderList = _db.Orders.ToList();
            return View(objOrderList);

            //return View();
        }
    }
}
