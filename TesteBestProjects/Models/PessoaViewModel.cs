using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TesteBestProjects.Models
{
    public class PessoaViewModel
    {

        public Int32 PessoaId { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Nome")]
        public String Nome { get; set; }

        [Required(ErrorMessage = "O Telefone é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Telefone")]
        public String Telefone { get; set; }

        [Required(ErrorMessage = "O celular é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Celular")]
        public String Celular { get; set; }


    }
}