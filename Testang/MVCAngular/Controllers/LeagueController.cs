using System.Web.Mvc;
using MVCAngular.Models.Start;

namespace MVCAngular.Controllers
{
    public class LeagueController : Controller
    {
        private StartVmBuilder _regristrationVmBuilder = new StartVmBuilder();

        public ActionResult Index()
        {
            return View("index", "", _regristrationVmBuilder.GetSerializedLeagues());
        }
  
    }
}