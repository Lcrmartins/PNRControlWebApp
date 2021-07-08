using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PNRControlWebApp.Models
{
    public class Ocupacao
    {
        public int Id { get; set; }
        public PNR Pnr { get; set; }
        public Militar Militar { get; set; }

        [Display(Name = "Data de Ocupação")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Ocupa { get; set; }

        [Display(Name = "Data de Desocupação")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Desocupa { get; set; }
    }
}
