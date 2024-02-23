using MediatR;

namespace BusinessLogic.Abstractions.Messaging
{
    public interface IQuery<TResponse> : IRequest<TResponse>
    {
    }
}
