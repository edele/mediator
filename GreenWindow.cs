using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class GreenWindow : BaseWindow
    {
        public GreenWindow(int x, int y, int w, int h)
            : base(x, y, w, h)
        {
            color = ConsoleColor.Green;
        }
    }
}
