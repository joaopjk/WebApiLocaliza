using System;

namespace Utilitarios.Util
{
    /// <summary>
    /// Classe para tratar Exception API
    /// </summary>
    public class ApiException : Exception
    {
        public StatusCode StatusCode;
        public long Code;
        public ApiException() : base()
        { }
        public ApiException(string message) : base(message)
        {
            this.StatusCode = StatusCode.InternalServerError;
        }
        /// <summary>
        /// Construtor
        /// </summary>
        public ApiException(StatusCode statusCode, MSG MSG, string Campo = "", string Mensagem = "")
        : base(((int)MSG).ToString() + " - " + MSGD.GetDescription(MSG) + ((Campo == "") ? "" : " - Campo: " + Campo) + ((Mensagem == "") ? "" : " - " + Mensagem))
        {
            this.StatusCode = statusCode;
            this.Code = (int)MSG;
        }
    }
}
