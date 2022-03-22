using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.About
{
    public class _Statistics2:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using var c = new Context();
            ViewBag.s1 = "1730";
            ViewBag.s2 = "720";
            ViewBag.s3 = "30";
            return View();
        }
    }
}
