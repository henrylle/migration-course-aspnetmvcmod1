using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCProjetoEmpresa.Models
{
    public class Empresa
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o nome da empresa")]
        public string Nome { get; set; }
        
        [Required(ErrorMessage = "Informe a data de fundação da empresa")]
        public DateTime dtFundacao { get; set; }
    }
}