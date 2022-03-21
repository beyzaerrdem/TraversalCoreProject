using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.About
{
    public class _Guides:ViewComponent
    {
        GuideManager guideManager = new GuideManager(new EfGuideDal());
        public IViewComponentResult Invoke()
        {
            var values = guideManager.GetList();
            return View(values);
        }
    }
}
