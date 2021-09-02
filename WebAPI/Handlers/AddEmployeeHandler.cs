using System.Threading;
using System.Threading.Tasks;
using MediatR;
using System.Collections.Generic;
using WebAPI.Commands;
using WebAPI.Models;
using WebAPI.Data;

namespace WebAPI.Handlers
{
    public class AddEmployeeHandler : IRequestHandler<AddEmployeeCommand,EmployeeModel>
    {

        private readonly IDataAccess _dataAccess;

        public AddEmployeeHandler(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public Task<EmployeeModel> Handle(AddEmployeeCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_dataAccess.AddEmployee(request.FirstName,request.LastName));
        }
    }
}