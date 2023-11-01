using BusinessLogic.Models;

using MediatR;

namespace BusinessLogic.Queries.Employees.GetAll
{
    public record GetEmployeesQuery(): IRequest<IEnumerable<Employee>>;
}
