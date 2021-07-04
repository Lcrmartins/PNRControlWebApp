using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PNRControlWebApp.Data
{
    public enum Prioridade
    {
        /// <summary>
        /// "Militares cujos cargos ou funções dão direito a PNR 
        /// de representação e a PNR funcionais."
        /// </summary>
        prioridade_a = 1,
        /// <summary>
        /// "militares exonerados dos cargos que dão direito a PNR 
        /// de representação ou a PNR funcionais e que permanecerão 
        /// na área onde serve, exercendo outro cargo ou função."
        /// </summary>
        prioridade_b = 2,
        /// <summary>
        /// "Militares lotados em OM da área, acompanhados de dependentes, 
        /// não possuidores de imóveis residenciais na área."
        /// </summary>
        prioridade_c = 3,
        /// <summary>
        /// "Militares lotados em OM da área, sem dependentes ou 
        /// desacompanhados destes, não possuidores de imóveis 
        /// residenciais na área."
        /// </summary>
        prioridade_d = 4,
        /// <summary>
        /// "Militares lotados em OM de outras áreas, cumprindo missão 
        /// temporária, que não possuem imóveis residenciais na área."
        /// </summary>
        prioridade_e = 5,
        /// <summary>
        /// "Militares enquadrados nos casos anteriores, que sejam 
        /// proprietários(as), promitente comprador(a) ou cessionário(a),
        /// de imóvel residencial na área."
        /// </summary>
        prioridade_f = 6
    }
}
