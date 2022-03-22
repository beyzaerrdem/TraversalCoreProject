using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.About
{
    public class _About2:ViewComponent
    {
        About2Manager about2Manager = new About2Manager(new EfAbout2Dal());
        public IViewComponentResult Invoke()
        {
            var values = about2Manager.GetList();
            return View(values);
        }
    }
}
