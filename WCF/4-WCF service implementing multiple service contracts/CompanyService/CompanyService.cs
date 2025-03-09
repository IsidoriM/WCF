using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CompanyService
{
    // NOTA: è possibile utilizzare il comando "Rinomina" del menu "Refactoring" per modificare il nome di classe "CompanyService" nel codice e nel file di configurazione contemporaneamente.
    public class CompanyService : IMyCompanyPublicService, IMyCompanyConfidentialService
    {
        public void DoWork()
        {
        }

        public string GetPublicInformation()
        {
            return "This is public information and available over HTTP to all general public outside the FireWall";
        }

        public string GetCofidentialInformation()
        {
            return "This is confidential information and only available over TCP behind the company FireWall";
        }
    }
}
