using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PNRControlWebApp.Models
{
    public class Ocupacao
    {
        public int Id { get; set; }
        public PNR Pnr { get; set; }
        public Militar Militar { get; set; }
        public DateTime Ocupa { get; set; }
        public DateTime Desocupa { get; set; }
    }
}
