using System.Collections.Generic;
using WebAPI.Models;
using MediatR;

namespace WebAPI.Queries
{
    public record GetEmployeeListQuery(): IRequest<List<EmployeeModel>>;
}