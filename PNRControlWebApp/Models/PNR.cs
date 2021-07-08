using Microsoft.EntityFrameworkCore;
using PNRControlWebApp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace PNRControlWebApp.Models
{
    public class PNR
    {
        [Key]
        public int Id { get; set; }
        [Required]
        // é necessário garantir que o Código é unico. ver http://www.macoratti.net/20/06/aspc_crident11.htm
        // e https://docs.microsoft.com/pt-br/aspnet/core/mvc/models/validation?view=aspnetcore-5.0
        [StringLength(6, ErrorMessage = "O campo Código deve ter 6 caracteres.", MinimumLength = 6)]
        public string Codigo { get; set; }
        [Required(ErrorMessage = "O campo Cidade é mandatório.")]
        [StringLength(30, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres.", MinimumLength = 3)]
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
        [Range(1, 99999)]
        public int Numero { get; set; }
        [StringLength(100, ErrorMessage = "O campo Complemento tem o máximo de 100 caracteres.")]
        public string Complemento { get; set; }

        [Required(ErrorMessage = "O campo Tipo é mandatório.")]
        public Tipo Tipo { get; set; }
        [Required(ErrorMessage = "O campo Categoria é mandatório.")]
        public Categoria Categoria { get; set; }
        [Required(ErrorMessage = "O campo Natureza é mandatório.")]
        public Natureza Natureza { get; set; }
        [StringLength(300, ErrorMessage = "O campo Descrição tem o máximo de 300 caracteres.")]
        public string Descricao { get; set; }
        [StringLength(100, ErrorMessage = "O campo Descrição tem o máximo de 100 caracteres.")]
        public string Observacao { get; set; }
        [StringLength(8, ErrorMessage = "O campo deve ter 8 algarismos. Não colocar pontos ou traços.", MinimumLength = 8)]
        public string CEP { get; set; }
               
    }
}
