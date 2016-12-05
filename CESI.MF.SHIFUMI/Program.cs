using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CESI.MF.SHIFUMI
{
    class Program
    {
        static void Main(string[] args){
            Console.WriteLine("Shifumi started");
            GameRules rules = new GameRules();
            int tour = 1;
            Human j1 = new Human();
            Computer j2 = new Computer();
            
            while (tour < 11) {
                Console.WriteLine("\n Tour :"+tour+"\n"+"Score: "+j1.name+"("+j1.Score+") / " + j2.name + "(" + j2.Score + ")" + "\n Choisissez un coup: (1) pierre, (2) ciseaux, (3) feuille");
                int j1Input = (int.Parse(Console.ReadLine()));
                int j2Input = j2.play();
                Console.WriteLine(j1.name + " joue  : {0}", rules.determine(j1Input));
                Console.WriteLine("Cpu joue  : {0}", rules.determine(j2Input));
                int winner=rules.compare(j1Input,j2Input);
                if(winner==1) {
                    j1.Score += 1;
                }else if(winner == 2) {
                    j2.Score += 1;
                }else {
                    Console.WriteLine("égalité, manche nulle");
                }

                if (j1.Score == 3) {
                    Console.WriteLine(j1.name + " gagne la partie");
                    break;
                }
                else if (j2.Score == 3) {
                    Console.WriteLine(j2.name + " gagne la partie");
                    break;
                }
                tour++;
            }

            Console.WriteLine("Shifumi ended");
            Console.ReadLine();
        }
    }
}
