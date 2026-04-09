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
                // In a full app, you would save this to the Transaction History DB here
                model.IsCalculated = true;
            }
            return View(model);
        }
    }
}