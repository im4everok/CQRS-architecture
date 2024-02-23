using BusinessLogic.Abstractions.Messaging;
using BusinessLogic.Models;

namespace BusinessLogic.Queries.Employees.GetCachedEmployeeByIdQuery
{
    public record GetCachedEmployeeByIdQuery(int Id) : ICachedQuery<Employee>
    {
        public string CacheKey => $"users-by-id-{Id}";

        public TimeSpan? Expiration => null;
    }
}
