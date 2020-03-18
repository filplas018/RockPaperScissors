using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RockPaperScissors.Model
{
    public class Rps
    {
        public Choice Player { get; set; }
        public Choice Computer { get; set; }
        public int Wins { get; set; }
        public int Loss { get; set; }
        public int Draw { get; set; }
        public int Round { get; set; }
        public bool? PlayerIsWinner { get; set; }
    }
}
