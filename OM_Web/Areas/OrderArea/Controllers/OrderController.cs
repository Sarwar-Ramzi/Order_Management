using Microsoft.AspNetCore.Mvc;
using OM.DataAccess.Data;
using OM.Models;

namespace OM_Web.Areas.OrderArea.Controllers
{
    [Area("OrderArea")]
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
