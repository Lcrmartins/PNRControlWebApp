using PNRControlWebApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PNRControlWebApp.Models
{
    public class Militar: Pessoa
    {            
        public OM OM { get; set; }
        public string Setor { get; set; }
        public string TelefoneSetor { get; set; }
        public Posto_Graduacao PostoGraduacao { get; set; }
    }
}
