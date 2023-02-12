using ETicaretApp.Application.Features.Commands.ProductCQRS.CreateProduct;
using ETicaretApp.Application.Features.Commands.ProductCQRS.RemoveProduct;
using ETicaretApp.Application.Features.Commands.ProductCQRS.UpdateProduct;
using ETicaretApp.Application.Features.Queries.GetAllProducts;
using ETicaretApp.Application.Features.Queries.GetByIdProduct;
using ETicaretApp.Application.Repositories;
using ETicaretApp.Application.ViewModels.Products;
using ETicaretApp.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
     
        private readonly IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get(GetAllProductQueryRequest getAllProductQueryRequest)
        {
            GetAllProductQueryResponse response = await _mediator.Send(getAllProductQueryRequest);
            return Ok(response);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromQuery]GetByIdProductQueryRequest model)
        {
            GetByIdProductQueryResponse response = await _mediator.Send(model);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateProductCommandRequest model)
        {
            CreateProductCommandResponse response = await _mediator.Send(model);
    
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Put(UpdateProductCommandRequest model)
        {
            UpdateProductCommandResponse response = await _mediator.Send(model);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(RemoveProductCommandRequest model)
        {
            RemoveProductCommandResponse response = await _mediator.Send(model);
            return Ok();
        }
    }
}
