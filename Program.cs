using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            var os = new WindowsXP();
            var w1 = new RedWindow(10, 10, 10, 6);
            var w2 = new GreenWindow(12, 8, 6, 10);
            os.RegisterObject(w1);
            os.RegisterObject(w2);
            os.SendMessage(null, MessageType.RepaintAll);

            while (true)
            {
                ConsoleKeyInfo info = Console.ReadKey(true);
                switch (info.Key)
                {
                    case ConsoleKey.LeftArrow:
                        w1.Move(-1, 0);
                        break;
                    case ConsoleKey.RightArrow:
                        w1.Move(1, 0);
                        break;
                    case ConsoleKey.DownArrow:
                        w1.Move(0, 1);
                        break;
                    case ConsoleKey.UpArrow:
                        w1.Move(0, -1);
                        break;
                }
            }

            Console.ReadLine();
        }
    }
}
