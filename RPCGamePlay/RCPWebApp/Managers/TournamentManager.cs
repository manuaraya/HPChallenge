using RPSWebApp.DAL;
using RPSWebApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using RPCGamePlay.Core;

namespace RPSWebApp.Managers
{
    public static class TournamentManager
    {
        public static void UpdateTournamet(Player winner)
        {
            using (var dbContext = new RPSContext())
            {

                var TournamentWinner = (from data in dbContext.Tournaments
                                        where data.playerName == winner.name
                                        select data).FirstOrDefault();
                if (TournamentWinner != null)
                {
                    TournamentWinner.points += 3;
                    dbContext.SaveChanges();
                }
                else { InsertWinner(winner); }
            }
        }

        private static void InsertWinner(Player winner)
        {
            using (var dbContext = new RPSContext())
            {
                dbContext.Tournaments.Add(new Tournament { playerName = winner.name, points = 3 });
                dbContext.SaveChanges();
            }
        }

        public static void ResetTournamentTable()
        {
            using (var dbContext = new RPSContext())
            {
                var tournamentWinners = dbContext.Tournaments.ToList();

                foreach (var winner in tournamentWinners)
                {
                    dbContext.Tournaments.Remove(winner);
                    dbContext.SaveChanges();
                }

            }

        }


    }
}