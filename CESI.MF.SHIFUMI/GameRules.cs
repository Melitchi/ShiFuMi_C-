using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CESI.MF.SHIFUMI
{
    class GameRules
    {
        public string determine(int input) {
            string choice="";
            switch (input)
            {
                case 1:
                    choice = "pierre";
                    break;
                case 2:
                    choice = "ciseaux";
                    break;
                case 3:
                    choice = "feuille";
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
            return choice;
        }
        public int compare(int j1Val, int j2Val) {
            int winner=0; // 0 = égalité, 1 = j1, 2= j2
            if (j1Val == j2Val){
                winner = 0;
            }
            else{
                switch (j1Val){
                    case 1: // j1 = pierre
                        if(j2Val == 2) {
                            winner = 1;
                        }else {
                            winner = 2;
                        }
                        break;
                    case 2: //j1 = ciseaux
                        if (j2Val == 3){
                            winner = 1;
                        }
                        else
                        {
                            winner = 2;
                        }
                        break;
                    case 3: //j1 = feuille
                        if (j2Val == 1){
                            winner = 1;
                        }
                        else {
                            winner = 2;
                        }
                        break;
                    default:
                        Console.WriteLine("Default case");
                        break;
                }
            }
            return winner;
        }
    }
}
