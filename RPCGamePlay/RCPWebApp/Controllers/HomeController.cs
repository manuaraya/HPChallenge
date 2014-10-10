using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RPSWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Let's play some Rock-Paper-Scissors";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult Upload()
        {
            if (Request.Files.Count > 0)
            {
                var file = Request.Files[0];

                if (file != null && file.ContentLength > 0)
                {
                    var fileName = Path.GetFileName(file.FileName);
                    var path = Path.Combine(Server.MapPath("~/TournamentFiles/"));
                    file.SaveAs(path);
                    return RedirectToAction("Result", "Result", new { filePath = path });
                }
            }
            return RedirectToAction("Index","Home");


        }

        [HttpGet]
        public ActionResult ResetData()
        {
            RPSWebApp.Managers.TournamentManager.ResetTournamentTable();

            return RedirectToAction("Index", "Home");
        }

    }
}
