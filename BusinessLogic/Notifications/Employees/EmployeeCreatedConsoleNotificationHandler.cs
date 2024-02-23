using MediatR;

namespace BusinessLogic.Notifications.Employees
{
    public class EmployeeCreatedConsoleNotificationHandler : INotificationHandler<EmployeeCreatedNotification>
    {
        public Task Handle(EmployeeCreatedNotification notification, CancellationToken cancellationToken)
        {
            Console.WriteLine($"Notification that employee was created with name: {notification.Employee.Name}");

            return Task.CompletedTask;
        }
    }
}
