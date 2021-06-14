using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int RollNum;
            int EnemyRollNum;
            int PlayerPoints = 0;
            int EnemyPoints = 0;


            Random random = new Random();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Press enter to roll the dice.");
                Console.ReadKey();
                
                RollNum = random.Next(1, 7);
                Console.WriteLine("Your rolled a " + RollNum);
                
                EnemyRollNum = random.Next(1, 7);
                Console.WriteLine("Your enemy rolled a " + EnemyRollNum);

                if (RollNum > EnemyRollNum)
                {
                    PlayerPoints++;
                    Console.WriteLine("Player win this game!");
                }
                else if (RollNum < EnemyRollNum)
                {
                    EnemyPoints++;
                    Console.WriteLine("Enemy win this game!");
                }
                else
                {
                    Console.WriteLine("DRAW!");
                }
                Console.WriteLine("The score is Player: " + PlayerPoints + " Enemy: " + EnemyPoints + "!");
            }
            if (PlayerPoints > EnemyPoints)
            {
                Console.WriteLine("You WIN!");
            }
            else if (PlayerPoints < EnemyPoints)
            {
                Console.WriteLine("You LOSE!");
            }
            else
            {
                Console.WriteLine("DRAW!");
            }
            Console.ReadKey();


        }
            
    }
}
