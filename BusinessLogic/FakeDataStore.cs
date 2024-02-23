using BusinessLogic.Models;

namespace BusinessLogic
{
    public class FakeDataStore
    {
        private static List<Employee> employees;

        public FakeDataStore()
        {
            employees = new List<Employee>
            {
                new() { Id = 1, Name = "Andruha" },
                new() { Id = 2, Name = "Ksuha" },
                new() { Id = 3, Name = "Dimon" }
            };
        }

        public async Task<Employee> AddEmployee(string name)
        {
            employees.Add(new Employee { Id = employees.Last().Id + 1, Name = name });

            return await Task.FromResult(employees.Where(e => e.Name == name).First());
        }

        public async Task<IEnumerable<Employee>> GetAllEmployees() => await Task.FromResult(employees);
    }
}
