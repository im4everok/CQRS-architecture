namespace BusinessLogic.Abstractions.Caching
{
    public interface ICacheService
    {
        Task<T> GetOrCreateAsync<T>(string key,
            Func<CancellationToken, Task<T>> factory,
            TimeSpan? expiration,
            CancellationToken cancellationToken);
    }
}
