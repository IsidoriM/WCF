using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CompanyService
{
    // NOTA: è possibile utilizzare il comando "Rinomina" del menu "Refactoring" per modificare il nome di interfaccia "ICompanyService" nel codice e nel file di configurazione contemporaneamente.
    [ServiceContract]
    public interface IMyCompanyPublicService
    {
        [OperationContract]
        string GetPublicInformation();
    }

    [ServiceContract]
    public interface IMyCompanyConfidentialService
    {
        [OperationContract]
        string GetCofidentialInformation();
    }
}
