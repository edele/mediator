using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public enum MessageType
    {
        Empty, Test, RepaintAll
    }
    interface IControl
    {

        void RegisterObject(BaseWindow wnd);
        void SendMessage(BaseWindow caller,
                         MessageType message
            );
    }
}
