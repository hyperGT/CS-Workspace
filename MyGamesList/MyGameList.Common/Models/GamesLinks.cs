using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGameList.Common.Models
{
    public class GamesLinks
    {
        public string GameName {get; set;}
        public int ID {get; set;}
        public List<string> GamesList {get; set;}
        public int[] IdList {get; set;}

        public void GetGamesList()
        {       
            foreach(string gameNames in GamesList){
                Console.WriteLine($"{gameNames}");
            }
        }
    }
}