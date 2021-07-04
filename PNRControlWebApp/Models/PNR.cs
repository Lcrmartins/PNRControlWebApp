using PNRControlWebApp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PNRControlWebApp.Models
{
    public class PNR
    {
        [Key]
        public int Id { get; set; }
        
        public string Codigo { get; set; }
        [Required(ErrorMessage = "O campo Cidade é mandatório.")]
        [StringLength(100, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres.", MinimumLength = 3)]
        public string Cidade { get; set; }
        [Required(ErrorMessage = "O campo Bairro é mandatório.")]
        [Display(Name = "Bairro ou Condomínio")]
        [StringLength(100, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres.", MinimumLength = 3)]
        public string Bairro { get; set; }
        
        [Required(ErrorMessage = "O campo Alameda/Avenida/Rua é mandatório.")]
        [Display(Name = "Alameda/Avenida/Rua")]
        [StringLength(100, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres.", MinimumLength = 3)]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo Numero é mandatório.")]
        [Display(Name = "Número")]
        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Digite somente algarismos")]
        [StringLength(100, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres.", MinimumLength = 3)]
        public int Numero { get; set; }
        public string Complemento { get; set; }
        [Required(ErrorMessage = "O campo Numero é mandatório.")]
        public Tipo Tipo { get; set; }
        public string Descricao { get; set; }
        public string CEP { get; set; }
    }
}
