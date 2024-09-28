using AutoMapper;
using MediatR;
using Tutorial_OnionCQRS.Application.Interfaces.Repositories;
using Tutorial_OnionCQRS.Application.Wrappers;

namespace Tutorial_OnionCQRS.Application.Features.Queries.GetProductById
{
    public class GetProductByIdQeryHandler : IRequestHandler<GetProductByIdQuery, ServiceResponse<GetProductByIdViewModel>>
    {
        private readonly IMapper _mapper;
        private readonly IProductRepository _productRepository;
        public GetProductByIdQeryHandler(IMapper mapper , IProductRepository productRepository)
        {
            _mapper= mapper;
            _productRepository= productRepository;
        }

        public async Task<ServiceResponse<GetProductByIdViewModel>> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var data = await _productRepository.GetByIdAsync(request.Id);
            
            var dto = _mapper.Map<GetProductByIdViewModel>(data);

            return new ServiceResponse<GetProductByIdViewModel>(dto);
        }
    }
}
