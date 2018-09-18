using App.ServiceLibrary;
using Microsoft.AspNetCore.Mvc;

namespace App.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IClassService _service;

        public ValuesController(IClassService service)
        {
            _service = service;
        }

        [HttpGet]
        public void Get()
        {
            _service.DoWork();
        }

    }
}
