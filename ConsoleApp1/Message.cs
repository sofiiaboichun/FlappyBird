using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Message
    {
        public void NewMessage(int sco, int h)
        {
            if (sco == 1)
            {
                Console.SetCursorPosition(0, h + 5);
                Console.Write("Good job!");
            }
            if (sco >= 5)
            {
                Console.SetCursorPosition(0, h + 5);
                Console.Write("So cool!!! Great job!");
            }
            if (sco >= 10)
            {
                Console.SetCursorPosition(0, h + 5);
                Console.Write("OMG! That's awesome!");
            }
        }

    }
}
