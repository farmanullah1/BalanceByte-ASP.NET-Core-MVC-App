using Microsoft.AspNetCore.Mvc;
using BalanceByte.Models;

namespace BalanceByte.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new RechargeModel());
        }

        [HttpPost]
        public IActionResult Index(RechargeModel model)
        {
            if (ModelState.IsValid)
            {
                model.IsCalculated = true;
            }
            return View(model);
        }
    }
}