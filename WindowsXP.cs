using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    /// <summary>
    /// Конкретный посредник
    /// CertainMediator
    /// </summary>
    class WindowsXP : BaseOS
    {
        public WindowsXP()
        {
            windows = new List<BaseWindow>();
        }

        public override void Draw()
        {
            Console.SetCursorPosition(0, 0);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Windows XP SP3");
        }
    }
}
