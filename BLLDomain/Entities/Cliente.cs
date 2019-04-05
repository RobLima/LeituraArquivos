using System;
using System.Collections.Generic;
using System.Text;

namespace BLLDomain.Entities
{
    public class Cliente
    {
        public int ClienteId {get;set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Sexo { get; set; }
        public string Email { get; set; }
        public bool Ativo { get; set; }


        public virtual IEnumerable<Produto> Produtos { get; set; }
    }
}
