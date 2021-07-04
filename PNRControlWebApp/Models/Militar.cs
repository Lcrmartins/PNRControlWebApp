using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PNRControlWebApp.Models
{
    public class Militar: Pessoa
    {            
        public string OM { get; set; }
        public string Setor { get; set; }
        public string TelefoneSetor { get; set; }
        public string PostoGraduacao { get; set; }
    }
}
