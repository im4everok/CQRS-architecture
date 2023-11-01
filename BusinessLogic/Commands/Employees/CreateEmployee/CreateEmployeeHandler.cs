using BusinessLogic.Models;

using MediatR;

namespace BusinessLogic.Commands.Employees.CreateEmployee
{
    public class CreateEmployeeHandler : IRequestHandler<CreateEmployeeCommand, Employee>
    {
        private FakeDataStore _fakeDataStore;

        public CreateEmployeeHandler(FakeDataStore fakeDataStore)
        {
            _fakeDataStore = fakeDataStore;
        }

        public async Task<Employee> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var addedEmployee = await _fakeDataStore.AddEmployee(request.Employee.Name);

            return addedEmployee;
        }
    }
}
