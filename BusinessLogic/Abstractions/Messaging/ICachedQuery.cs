namespace BusinessLogic.Abstractions.Messaging
{
    public interface ICachedQuery<TResponse> : IQuery<TResponse>, ICachedQuery
    {

    }

    public interface ICachedQuery
    {
        public string CacheKey { get; }
        public TimeSpan? Expiration { get; }
    }
}
