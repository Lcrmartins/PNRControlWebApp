using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PNRControlWebApp.Models
{
    public class Pessoa
    {
        [Key]
        public int Id { get; set; }
        public string NomeCompleto { get; set; }
        [Required(ErrorMessage ="O campo telefone é obrigatório.")]
        [RegularExpression(@"^\(?(?:[14689][1-9]|2[12478]|3[1234578]|5[1345]|7[134579])\)? ?(?:[2-8]|9[1-9])[0-9]{3}\-?[0-9]{4}$", ErrorMessage = "O telefone digitado não está no formato correto. Digite somente o DDD e o telefone. Somente os algarismos")]
        public string Telefone { get; set; }
        [EmailAddress(ErrorMessage = "E-mail inválido.")]
        public string Email { get; set; }
    }
}
