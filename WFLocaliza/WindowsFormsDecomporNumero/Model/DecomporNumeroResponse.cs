using System.Collections.Generic;

namespace WindowsFormsDecomporNumero.Model
{
    #region Get
    /// <summary>
    /// Propriedades de Saída DecomporNumero
    /// </summary
    public class DecomporNumeroResponse
    {
        /// <summary>
        /// Todos os divisores que compõem um número
        /// </summary>
        public List<long> divisores { get; set; }
        /// <summary>
        /// Todos os divisores primos que compõem um número
        /// </summary>
        public List<long> divisoresPrimos { get; set; }

        public DecomporNumeroResponse()
        {
            divisores = new List<long>();
            divisoresPrimos = new List<long>();
        }
    }
    #endregion
}
