using Api.DTO;
using Api.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using Utilitarios;
using Utilitarios.Util;

namespace Api.Service.Service
{
    public class DecomporNumeroService : IDecomporNumeroService
    {
        ApiResponse _apiResponse = null;
        DecomporNumeroResponse _response = null;
        public DecomporNumeroService()
        {
            _apiResponse = new ApiResponse();
        }
        public void Dispose()
        {
            if (_apiResponse != null)
            {
                _apiResponse = null;
            }
            if (_response != null)
            {
                _response = null;
            }
        }
        public ActionResult<DecomporNumeroResponse> DecomporNumero(long Request)
        {
            try
            {
                isValid(Request);

                _response = new DecomporNumeroResponse();

                Funcoes.DecomporNumero(Request, _response.divisores, _response.divisoresPrimos);

                return _apiResponse.ResponseRet<DecomporNumeroResponse>(StatusCode.OK, _response);
            }
            catch (ApiException ex)
            {
                return _apiResponse.ResponseRetWithoutEnumerable(ex);
            }
            catch (Exception ex)
            {
                return _apiResponse.ResponseRetWithoutEnumerable(ex);
            }
            finally
            {
                Dispose();
            }
        }
        public void isValid(long Request)
        {
            if (Request == 0)
            {
                throw new ApiException(StatusCode.BadRequest, MSG.NumeroZero);
            }
        }
    }
}
