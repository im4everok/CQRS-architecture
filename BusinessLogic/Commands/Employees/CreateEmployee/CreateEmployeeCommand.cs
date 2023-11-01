using BusinessLogic.Models;

using MediatR;

namespace BusinessLogic.Commands.Employees.CreateEmployee
{
    public record CreateEmployeeCommand(Employee Employee): IRequest<Employee>;
}
