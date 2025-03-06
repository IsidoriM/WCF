using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HelloService
{
    // NOTA: è possibile utilizzare il comando "Rinomina" del menu "Refactoring" per modificare il nome di classe "HelloService" nel codice e nel file di configurazione contemporaneamente.
    public class HelloService : IHelloService
    {
        public string GetMessage(string name)
        {
            return "Hello " + name;
        }
    }
}
