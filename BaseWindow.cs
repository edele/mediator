using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public delegate void Handler(string msg);

    /// <summary>
    /// Базовый коллега
    /// Base Collegue
    /// </summary>
    abstract class BaseWindow
    {
        public event Handler ScreenEdge;

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



            if (y <= 0)
            {
                y = 0;
                os.SendMessage(this, MessageType.RepaintAll);
                ScreenEdge("верхняя");
            }
            else
            if (y+h >= Console.WindowHeight)
            {
                y = Console.WindowHeight-h;
                os.SendMessage(this, MessageType.RepaintAll);
                ScreenEdge("нижняя");
            }
            else
            if (x <= 0)
            {
                x = 0;
                os.SendMessage(this, MessageType.RepaintAll);
                ScreenEdge("левая");
            } else
            if (x + w >= Console.WindowWidth)
            {
                x = Console.WindowWidth - w;
                os.SendMessage(this, MessageType.RepaintAll);
                ScreenEdge("правая");
            } else
            os.SendMessage(this, MessageType.RepaintAll);
        }

    }
}
