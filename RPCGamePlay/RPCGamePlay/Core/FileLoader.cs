using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using RPCGamePlay.Constants;

namespace RPCGamePlay.Core
{
   public static class FileLoader
    {
        public static List<Player> serializeFile(List<Player> players, string FileLocation)
        {          
                string[] lines = System.IO.File.ReadAllLines(FileLocation);

                Regex r = new Regex(regexBuilder(), RegexOptions.IgnoreCase | RegexOptions.Singleline);

                foreach (string line in lines)
                {
                    Match m = r.Match(line);
                    if (m.Success)
                    {
                        players.Add(new Player() { name = m.Groups[1].ToString().Replace("\"", ""), play = m.Groups[2].ToString().Replace("\"", "")[0] });
                        players.Add(new Player() { name = m.Groups[3].ToString().Replace("\"", ""), play = m.Groups[4].ToString().Replace("\"", "")[0] });
                    }
                }

                return players;
            }           
        

        public static string regexBuilder()
        {
            StringBuilder regex = new StringBuilder();

            regex.Append(GlobalConstants.re1);
            regex.Append(GlobalConstants.re2);
            regex.Append(GlobalConstants.re1);
            regex.Append(GlobalConstants.re2);
            regex.Append(GlobalConstants.re1);
            regex.Append(GlobalConstants.re2);
            regex.Append(GlobalConstants.re1);
            regex.Append(GlobalConstants.re2);

            return regex.ToString();
        }
    }
}
