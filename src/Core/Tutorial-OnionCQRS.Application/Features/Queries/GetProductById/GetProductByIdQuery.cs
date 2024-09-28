using MediatR;
using Tutorial_OnionCQRS.Application.Wrappers;

namespace Tutorial_OnionCQRS.Application.Features.Queries.GetProductById
{
    public class GetProductByIdQuery : IRequest<ServiceResponse<GetProductByIdViewModel>>
    {
        public Guid Id { get; set; }
    }
}
