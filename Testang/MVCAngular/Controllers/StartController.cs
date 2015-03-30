using System.Web.Mvc;
using MVCAngular.Models.Start;
using System.Collections.Generic;

namespace MVCAngular.Controllers
{
    public class StartController : Controller
    {

        private StartVmBuilder _startVmBuilder = new StartVmBuilder();

        public ActionResult Index()
        {
         
            return View(_startVmBuilder.BuildStartVm());
        }

    }
}
