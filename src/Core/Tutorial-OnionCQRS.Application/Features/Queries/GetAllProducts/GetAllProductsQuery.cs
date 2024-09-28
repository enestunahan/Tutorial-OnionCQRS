using AutoMapper;
using MediatR;
using Tutorial_OnionCQRS.Application.Dtos;
using Tutorial_OnionCQRS.Application.Interfaces.Repositories;
using Tutorial_OnionCQRS.Application.Wrappers;

namespace Tutorial_OnionCQRS.Application.Features.Queries.GetAllProducts
{
    public class GetAllProductsQuery : IRequest<ServiceResponse<List<ProductViewDto>>>
    {

        public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, ServiceResponse<List<ProductViewDto>>>
        {
            
            private readonly IProductRepository _productRepository;
            private readonly IMapper _mapper;
           

            public GetAllProductsQueryHandler(IProductRepository productRepository , IMapper mapper)
            {
                _productRepository= productRepository;  
                _mapper= mapper;
            }


            public async Task<ServiceResponse<List<ProductViewDto>>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
            {
                var products = await _productRepository.GetAllAsync();

                var responseData = _mapper.Map<List<ProductViewDto>>(products);

                return new ServiceResponse<List<ProductViewDto>>(responseData);
            }
        }
    }
}
