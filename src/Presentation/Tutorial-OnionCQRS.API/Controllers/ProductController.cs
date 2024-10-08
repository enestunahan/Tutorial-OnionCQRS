﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using Tutorial_OnionCQRS.Application.Features.Commands.CreateProduct;
using Tutorial_OnionCQRS.Application.Features.Queries.GetAllProducts;
using Tutorial_OnionCQRS.Application.Features.Queries.GetProductById;

namespace Tutorial_OnionCQRS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var query = new GetAllProductsQuery();
            return Ok(await _mediator.Send(query));
        }

        [HttpGet("id")]
        public async Task<IActionResult> Get(Guid id)
        {
            var query = new GetProductByIdQuery() { Id = id };
            return Ok(await _mediator.Send(query));
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateProductCommand createProductCommand)
        {
            return Ok(await _mediator.Send(createProductCommand));
        }
    }
}
