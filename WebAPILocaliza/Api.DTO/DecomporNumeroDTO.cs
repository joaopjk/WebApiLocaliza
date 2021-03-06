﻿using System.Collections.Generic;

namespace Api.DTO
{
    #region Get
    /// <summary>
    /// Propriedades de Saída da Controller DecomporNumeroController
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
