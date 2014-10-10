using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RPSWebApp.Models;
using RPSWebApp.DAL;

namespace RPSWebApp.Controllers
{
    public class TopPlayerController : Controller
    {
        private RPSContext db = new RPSContext();

        //
        // GET: /TopPlayer/

        public ActionResult Index()
        {
            return View(db.Tournaments.ToList().OrderBy(u => u.points).Take(10));
        }

        
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}