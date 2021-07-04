using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PNRControlWebApp.Models
{
    public class PNR
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Nome { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Tipo { get; set; }
        public string Descricao { get; set; }
        public string CEP { get; set; }
    }
}
