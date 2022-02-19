using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using OnlineGame.Web.Data;
using OnlineGame.Web.Models;
namespace OnlineGame.Web.Controllers
{
    public class TeamController : Controller
    {
        public ActionResult Index()
        {
            OnlineGameContext context = new OnlineGameContext();
            List<Team> teams = context.Teams.ToList();
            return View(teams);
        }
    }
}