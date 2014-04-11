using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    /// <summary>
    /// Базовый коллега
    /// Base Collegue
    /// </summary>
    abstract class BaseWindow
    {
        public IControl os {get; set;}
        protected int x, y, w, h;
        protected ConsoleColor color;
        public BaseWindow(int x, int y, 
                          int w, int h)
        {
            this.x = x; this.y = y;
            this.w = w; this.h = h;
            color = ConsoleColor.Black;
        }

        public void Draw()
        {
            Console.BackgroundColor = color;
            for (int i = 0; i < h; i++)
            {
                Console.SetCursorPosition(x, y + i);
                for (int j = 0; j < w; j++)
                {
                    Console.Write(" ");
                }
            }
        }

        public void Move(int dx, int dy)
        {
            x += dx; y += dy;
            os.SendMessage(this, MessageType.RepaintAll);
        }

    }
}
