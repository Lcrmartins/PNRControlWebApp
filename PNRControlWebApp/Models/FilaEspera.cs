using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PNRControlWebApp.Models
{
    public class FilaEspera
    {
        public int Id { get; set; }
        public DateTime DataInscricao { get; set; }
        public string Prioridade { get; set; }
        public string Descricao { get; set; }
        public Militar Militar { get; set; }
        public string Documento { get; set; }
    }
}
