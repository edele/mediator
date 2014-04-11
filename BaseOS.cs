using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    /// <summary>
    /// Базовый посредник
    /// Mediator Base
    /// </summary>
    abstract class BaseOS : IControl
    {
        protected List<BaseWindow> windows;

        public void RegisterObject(BaseWindow wnd)
        {
            windows.Add(wnd);
            wnd.os = this;
        }

        public abstract void Draw();

        public void SendMessage(BaseWindow caller, MessageType message)
        {
            switch (message)
            {
                case MessageType.Empty:
                    break;
                case MessageType.Test:
                    break;
                case MessageType.RepaintAll:
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                    Draw();
                    foreach (var w in windows)
                    {
                        w.Draw();
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
