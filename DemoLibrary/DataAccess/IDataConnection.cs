using DemoLibrary.Models;

namespace DemoLibrary.DataAccess
{
    public interface IDataConnection
    {
        EmployeeModel CreateEmployee(EmployeeModel model);

        
    }
}
