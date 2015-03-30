using System.Web.Mvc;
using MVCAngular.Models.Start;

namespace MVCAngular.Controllers
{
    public class TeamController : Controller
    {
        private StartVmBuilder _startVmBuilder = new StartVmBuilder();

        public ActionResult Index()
        {
            return View("index", "", _startVmBuilder.GetSerializedTeams());
        }
  
    }
}
