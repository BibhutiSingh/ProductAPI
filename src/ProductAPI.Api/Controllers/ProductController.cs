using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Web.Resource;

namespace ProductAPI.Api.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    [RequiredScope(RequiredScopesConfigurationKey = "AzureAd:Scopes")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        
        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }
        public IActionResult GetProduct(Guid Id)
        {
            return Problem();
        }

        
    }
}