using System.Collections.Generic;
using WebAPI.Models;

namespace WebAPI.Data
{
    public interface IDataAccess
    {
        List<EmployeeModel> GetEmployees();

        EmployeeModel AddEmployee(string firstName, string lastName);
    }
}