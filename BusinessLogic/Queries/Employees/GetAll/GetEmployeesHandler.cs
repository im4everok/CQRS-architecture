using BusinessLogic.Models;

using MediatR;

namespace BusinessLogic.Queries.Employees.GetAll
{
    public class GetEmployeesHandler : IRequestHandler<GetEmployeesQuery, IEnumerable<Employee>>
    {
        private readonly FakeDataStore _fakeDataStore;

        public GetEmployeesHandler(FakeDataStore fakeDataStore) 
        {
            _fakeDataStore = fakeDataStore;
        }

        public Task<IEnumerable<Employee>> Handle(GetEmployeesQuery query, CancellationToken cancellationToken)
        {
            var employees = _fakeDataStore.GetAllEmployees();

            return employees;
        }
    }
}
