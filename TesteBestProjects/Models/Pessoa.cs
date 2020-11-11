using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TesteBestProjects.Models
{
    public class Pessoa
    {
        public int PessoaId { get; set; }

        [Required(ErrorMessage = "O nome da Pessoa é obrigatório", AllowEmptyStrings = false)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O Telefone da Pessoa é obrigatório", AllowEmptyStrings = false)]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "O Celular da Pessoa é obrigatório", AllowEmptyStrings = false)]
        public string Celular { get; set; }

    }
}