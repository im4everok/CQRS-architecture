using BusinessLogic.Models;

using MediatR;

namespace BusinessLogic.Notifications.Employees
{
    public record EmployeeCreatedNotification(Employee Employee) : INotification;
}
