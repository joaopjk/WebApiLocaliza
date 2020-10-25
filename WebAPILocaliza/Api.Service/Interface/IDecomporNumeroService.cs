using Api.DTO;
using Microsoft.AspNetCore.Mvc;

namespace Api.Service.Interface
{
    public interface IDecomporNumeroService
    {
        ActionResult<DecomporNumeroResponse> DecomporNumero(long Request);
    }
}
