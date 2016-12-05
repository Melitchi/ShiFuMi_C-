using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CESI.MF.SHIFUMI
{
    class Computer:Player
    {
        public Computer() {
            name = "cpu";
            Score = 0;
        }

        public int play()
        {
         return new Random().Next(1, 4); ;
        }
    }
}
