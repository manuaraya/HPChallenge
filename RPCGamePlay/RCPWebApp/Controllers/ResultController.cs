using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RPCGamePlay.Core;
using RPSWebApp.Managers;

namespace RPSWebApp.Controllers
{
    public class ResultController : Controller
    {
        //
        // GET: /Result/

        public ActionResult Result(string filePath)
        {

            List<Player> players = new List<Player>();
            FileLoader.serializeFile(players, filePath);
            Game newGame = new Game(players);
            var winner = newGame.play();

            TournamentManager.UpdateTournamet(winner);

            ViewBag.Winner = winner.ToString();
            return View();
        }

    }
}
