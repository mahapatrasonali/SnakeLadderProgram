using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    public class Snake
    {
        public static void snakeladderProgram()
        {
            int position = 0;
            Console.WriteLine("Start Positon Is :" + position);
        }
        public static void diceoutput()
        {
            Random random = new Random();
            int dicethrown = random.Next(1, 7);
            Console.WriteLine("\nDies Output is :" + dicethrown);
        }
        public static void Play()
        {
            Random random = new Random();
            int diescheck = random.Next(1, 4);
            switch (diescheck)
            {
                case 1:
                    Console.WriteLine("Ladder");
                    break;
                case 2:
                    Console.WriteLine("Snake");
                    break;
                default:
                    Console.WriteLine("No Play");
                    break;
            }
        }
    }
}
