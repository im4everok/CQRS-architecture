using BusinessLogic.Models;

using MediatR;

namespace BusinessLogic.Queries.Employees.GetById
{
    public record GetEmployeeByIdQuery(int Id) : IRequest<Employee>;
}
