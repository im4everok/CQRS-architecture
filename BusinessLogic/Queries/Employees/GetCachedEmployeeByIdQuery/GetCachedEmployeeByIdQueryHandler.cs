using BusinessLogic.Models;

using MediatR;

namespace BusinessLogic.Queries.Employees.GetCachedEmployeeByIdQuery
{
    public class GetCachedEmployeeByIdQueryHandler : IRequestHandler<GetCachedEmployeeByIdQuery, Employee>
    {
        private readonly FakeDataStore _fakeDataStore;

        public GetCachedEmployeeByIdQueryHandler(FakeDataStore fakeDataStore)
        {
            _fakeDataStore = fakeDataStore;
        }
        public async Task<Employee> Handle(GetCachedEmployeeByIdQuery request, CancellationToken cancellationToken)
        {
            var employee = (await _fakeDataStore.GetAllEmployees()).FirstOrDefault(e => e.Id == request.Id);

            return employee;
        }
    }
}
