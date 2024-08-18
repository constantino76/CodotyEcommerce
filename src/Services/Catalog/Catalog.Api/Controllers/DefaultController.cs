using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.Api.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    [Route("/")]
    public class DefaultController : ControllerBase
    {

        public String Get() {

            return "Running....";
        
        
        }
    }
}
