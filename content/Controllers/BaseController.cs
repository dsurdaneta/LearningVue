using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Vue2Spa.Controllers
{
    [Produces("apication/json")]
    public class BaseController : ControllerBase
    {
        public readonly IConfiguration configuration;
        public BaseController(IConfiguration config)
        {
            configuration = config;
        }
    }
}
