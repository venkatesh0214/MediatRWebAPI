using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MediatR;
using WebAPI.Models;
using WebAPI.Queries;
using WebAPI.Commands;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public EmployeesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<List<EmployeeModel>> Get()
        {
            return await _mediator.Send(new GetEmployeeListQuery());
        }

         [HttpPost]
        public async Task<EmployeeModel> Post([FromBody]EmployeeModel employeeModel)
        {
            return await _mediator.Send(new AddEmployeeCommand(employeeModel.FirstName,employeeModel.LastName));
        }
    }
}