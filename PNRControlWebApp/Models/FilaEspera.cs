using PNRControlWebApp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PNRControlWebApp.Models
{
    public class FilaEspera
    {
        public int Id { get; set; }
        [Display(Name = "Data-Hora de Inscrição")]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:u}", ApplyFormatInEditMode = true)]
        public DateTime DataHoraInscricao { get; set; }
        public Prioridade Prioridade { get; set; }
        public string Descricao { get; set; }
        public Militar Militar { get; set; }
        public string Documento { get; set; }
    }
}
