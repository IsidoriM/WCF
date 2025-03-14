using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EmployeeService
{
    // NOTA: è possibile utilizzare il comando "Rinomina" del menu "Refactoring" per modificare il nome di interfaccia "IEmployeeService" nel codice e nel file di configurazione contemporaneamente.
    [ServiceContract]
    public interface IEmployeeService
    {
        [OperationContract]
        Employee GetEmployee(int Id);

        [OperationContract]
        void SaveEmployee(Employee Employee);
    }
}
