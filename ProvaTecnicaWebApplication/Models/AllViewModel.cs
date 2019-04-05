using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProvaTecnicaWebApplication.Models
{
    public class AllViewModel
    {
        public IEnumerable<ClienteViewModel> clientesModel { get; set; }
        public List<ProdutoViewModel> produtosModel { get; set; }
    }
}