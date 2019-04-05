using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProvaTecnicaWebApplication.Models
{
    public class ProdutoViewModel
    {
        [Display(Name = "ID")]
        public int ProdutoId { get; set; }
        [Display(Name = "Nome")]
        public string Nome { get; set; }
        [Display(Name = "Cliente ID")]
        public int ClienteId { get; set; }
    }
}