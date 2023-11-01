using BusinessLogic.Models;

using MediatR;

namespace BusinessLogic.Queries.Employees.GetById
{
    public class GetEmployeeByIdHandler : IRequestHandler<GetEmployeeByIdQuery, Employee>
    {
        private readonly FakeDataStore _fakeDataStore;

        public GetEmployeeByIdHandler(FakeDataStore fakeDataStore)
        {
            _fakeDataStore = fakeDataStore;
        }

        public async Task<Employee> Handle(GetEmployeeByIdQuery request, CancellationToken cancellationToken)
        {
            var employee = (await _fakeDataStore.GetAllEmployees()).FirstOrDefault(e => e.Id == request.Id);

            return employee;
        }
    }
}
