using WebAPI.Models;
using MediatR;

namespace WebAPI.Commands
{
    public record AddEmployeeCommand(string FirstName,string LastName): IRequest<EmployeeModel>;
}