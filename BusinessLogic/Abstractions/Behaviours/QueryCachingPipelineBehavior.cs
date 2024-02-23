using BusinessLogic.Abstractions.Caching;
using BusinessLogic.Abstractions.Messaging;

using MediatR;

namespace BusinessLogic.Abstractions.Behaviours
{
    public sealed class QueryCachingPipelineBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : ICachedQuery
    {
        private readonly ICacheService _cacheService;

        public QueryCachingPipelineBehavior(ICacheService cacheService)
        {
            _cacheService = cacheService;
        }

        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            var result = await _cacheService.GetOrCreateAsync(request.CacheKey,
                _ => next(),
                request.Expiration, 
                cancellationToken);

            return result;
        }
    }
}
