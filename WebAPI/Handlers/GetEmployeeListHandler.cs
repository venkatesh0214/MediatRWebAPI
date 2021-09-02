using System.Threading;
using System.Threading.Tasks;
using MediatR;
using System.Collections.Generic;
using WebAPI.Queries;
using WebAPI.Models;
using WebAPI.Data;

namespace WebAPI.Handlers
{
    public class GetEmployeeListHandler: IRequestHandler<GetEmployeeListQuery,List<EmployeeModel>>
    {
        private readonly IDataAccess _dataAccess;

        public GetEmployeeListHandler(IDataAccess dataAccess)
        {
            _dataAccess= dataAccess;
        }

        public Task<List<EmployeeModel>> Handle(GetEmployeeListQuery request,CancellationToken cancellationToken)
        {
            return Task.FromResult(_dataAccess.GetEmployees());
        }
    }
}