using PNRControlWebApp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PNRControlWebApp.Models
{
    public class Militar: Pessoa
    {
        [Display(Name = "Nome de Guerra")]
        [Required(ErrorMessage = "O campo Nome de Guerra é obrigatório.")]
        public string NomeDeGuerra { get; set; }
        [Required(ErrorMessage = "O campo OM é obrigatório.")]
        public OM OM { get; set; }
        public string Setor { get; set; }
        [Required(ErrorMessage = "O campo NIP é mandatório.")]
        [StringLength(8, ErrorMessage = "O NIP deve ter 8 algarismos, sem os pontos.", MinimumLength = 8)]
        [RegularExpression("[0-9]", ErrorMessage = "O campo NIP só aceita algarismos, sem os pontos.")]
        public string NIP { get; set; }
        public string TelefoneSetor { get; set; }
        [Display(Name = "Posto ou Grad.")]
        [Required(ErrorMessage = "O campo Posto ou Graduação é obrigatório.")]
        public Posto_Graduacao PostoGraduacao { get; set; }
        [Display(Name = "Corpo / Espc.")]
        [Required(ErrorMessage = "O campo Corpo / Especialidade é obrigatório.")]
        public string CorpoQuadroAperfeicoamentoEspecialidade { get; set; }
    }
}
