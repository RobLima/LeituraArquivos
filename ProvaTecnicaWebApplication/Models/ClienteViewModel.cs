using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProvaTecnicaWebApplication.Models
{
    public class ClienteViewModel
    {

        [Display(Name = "ID")]
        public int ClienteId { get; set; }
        [Display(Name = "Nome")]
        public string Nome { get; set; }
        [Display(Name = "Sobrenome")]
        public string Sobrenome { get; set; }
        [Display(Name = "Data de Nascimento" )]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataNascimento { get; set; }
        [Display(Name = "Sexo")]
        public string Sexo { get; set; }
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "Ativo")]
        public bool Ativo { get; set; }
    }
}