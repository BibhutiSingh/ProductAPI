using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Web.Resource;
using ProductAPI.Api.Infrastructure.Helpers;
using ProductAPI.Application.Services;
using ProductAPI.Application.Services.Products.Models;
using ProductAPI.Core.Exceptions;

namespace ProductAPI.Api.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    [RequiredScope(RequiredScopesConfigurationKey = "AzureAd:Scopes")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly UnitOfWork _uow;

        public ProductController(ILogger<ProductController> logger, UnitOfWork unitOfWork)
        {
            _logger = logger;
            _uow=unitOfWork;
        }
        public IActionResult GetProduct(Guid Id)
        {
            return Problem();
        }
        [HttpPost]
        public IActionResult CreateProduct(ProductCreate model)
        {
            try
            {
                if (model is null || !ModelState.IsValid)
                {
                    throw new ModelValidationException(ModelState?.ToModelStateErrorString());
                }

               return Ok(_uow.ProductService.CreateProduct(model));
            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}