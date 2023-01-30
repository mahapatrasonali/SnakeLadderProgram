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
            Random random = new Random();
            int dicethrown = random.Next(1, 7);
            Console.WriteLine("\nDies Output is :" + dicethrown);
        }
    }
}
