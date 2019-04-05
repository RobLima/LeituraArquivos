using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProvaTecnicaWebApplication.Models
{
    public class ArquivosModel
    {
        public HttpPostedFileBase ArquivoClientes { get; set; }
        public HttpPostedFileBase ArquivoProdutos { get; set; }
    }
}