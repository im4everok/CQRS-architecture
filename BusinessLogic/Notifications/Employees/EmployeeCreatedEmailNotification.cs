using MediatR;

namespace BusinessLogic.Notifications.Employees
{
    public class EmployeeCreatedEmailNotificationHandler : INotificationHandler<EmployeeCreatedNotification>
    {
        public Task Handle(EmployeeCreatedNotification notification, CancellationToken cancellationToken)
        {
            // imagine that we call SMPT server and send email :)
            Console.WriteLine($"Email notification for employee creation: {notification.Employee.Name}");

            return Task.CompletedTask;
        }
    }
}
