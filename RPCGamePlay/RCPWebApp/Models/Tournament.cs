using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RPSWebApp.Models
{
    public class Tournament
    {
        [Key]
        public string playerName { get; set; }
        public int? points { get; set; }
    }
}