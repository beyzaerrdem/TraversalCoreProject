using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Controllers
{
    public class DestinationController : Controller
    {
        DestinationManager dm = new DestinationManager(new EfDestinationDal());

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult DestinationDetails(int id)
        {
            ViewBag.Id = id;
            var values = dm.GetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult DestinationDetails(Destination d)
        {
            return View();
        }


    }
}
