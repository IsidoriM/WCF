using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IHelloRemotingService
{
    public interface IHelloRemtingService
    {
        string GetMessage(string name);
    }
}
