using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HelloService
{
    // NOTA: è possibile utilizzare il comando "Rinomina" del menu "Refactoring" per modificare il nome di interfaccia "IHelloService" nel codice e nel file di configurazione contemporaneamente.
    [ServiceContract(Name = "IHelloService")]
    public interface IHelloServiceChanged
    {
        [OperationContract(Name = "GetMessage")]
        string GetMessageChanged(string name);
    }
}
