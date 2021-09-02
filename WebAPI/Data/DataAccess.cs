using System.Collections.Generic;
using WebAPI.Models;
using System.Linq;

namespace WebAPI.Data
{
    public class DataAccess : IDataAccess 
    {
        private List<EmployeeModel> _employee = new();

        public DataAccess()
        {
            _employee.Add(new EmployeeModel{Id=1,FirstName="Venkatesh",LastName="Kannan"});
            _employee.Add(new EmployeeModel{Id=1,FirstName="John",LastName="Smith"});

        }

        public List<EmployeeModel> GetEmployees()
        {
            return _employee;
        }

        public EmployeeModel AddEmployee(string firstName, string lastName)
        {
            EmployeeModel newEmployee = new() {FirstName=firstName,LastName=lastName};
            newEmployee.Id = _employee.Max(x => x.Id) + 1;

            return newEmployee;
        }
    }
}