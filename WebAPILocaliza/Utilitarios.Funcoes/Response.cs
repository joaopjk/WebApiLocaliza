using Microsoft.AspNetCore.Mvc;
using System;
using Utilitarios.Util;

namespace Utilitarios
{
    /// <summary>
    /// Classe para tratar da API (Geralmente GET)
    /// </summary>
    public class Response
    {
        public long Codigo;
        public String Mensagem;
    }
    public class ApiResponse : ControllerBase
    {
        private Response response = null;
        public ApiResponse()
        {
            response = new Response();
        }
        /// <summary>
        /// ActionResult que precisa do IEnumerable (Geralmente GET)
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        //Status 200~
        public ActionResult<T> ResponseRet<T>(StatusCode statusCode, Object result = null)
        {
            switch (statusCode)
            {
                case Util.StatusCode.Created:
                    return Created("Created", result);
                case Util.StatusCode.NoContent:
                    return NoContent();
                default:
                    if (result == null) return Ok();
                    return Ok(result);
            }
        }
        /// <summary>
        /// ActionResult sem IEnumerable (Geralmente PUT/DELETE/POST)
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        public ActionResult<T> ResponseRet<T>(ApiException result)
        {
            response.Codigo = result.Code;
            response.Mensagem = result.Message;

            switch (result.StatusCode)
            {
                case Util.StatusCode.BadRequest:
                    return BadRequest(response);
                case Util.StatusCode.NotFound:
                    return NotFound(response);
                case Util.StatusCode.PreconditionRequired:
                    return StatusCode(428, response);
                default:
                    return StatusCode(500, response);
            }
        }
        /// <summary>
        /// ActionResult sem IEnumerable (Geralmente PUT/DELETE/POST)
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        public ActionResult ResponseRetWithoutEnumerable(System.Exception result)
        {
            return ResponseRetWithoutEnumerable(new ApiException(result.Message));
        }
    }
}
