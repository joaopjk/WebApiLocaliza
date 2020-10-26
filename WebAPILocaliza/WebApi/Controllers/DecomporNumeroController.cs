using Api.DTO;
using Api.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("API/v1/[controller]")]
    [ApiVersion("1.0")]
    [ApiController]
    public class DecomporNumeroController : ControllerBase
    {
        private readonly IDecomporNumeroService _service;
        public DecomporNumeroController(IDecomporNumeroService Service)
        {
            this._service = Service;
        }

        [HttpGet("{Numero}")]
        public ActionResult<DecomporNumeroResponse> GET(long Numero)
        {
            return _service.DecomporNumero(Numero);
        }
    }
}
