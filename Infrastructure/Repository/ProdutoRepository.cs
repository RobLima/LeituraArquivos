using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLLDomain.Interfaces.Repositories;
using BLLDomain.Entities;
using System.Data.SqlClient;

namespace Infrastructure.Repository
{
   public class ProdutoRepository : IRepositoryProduto
    {
        protected Contexto Db = new Contexto();
        public IEnumerable<Produto> GetAll()
        {
            return Db.Set<Produto>().ToList();
        }



      
        public void AddList(List<Produto> lstProduto)
        {
            Db.Produtos.AddRange(lstProduto);
            Db.SaveChanges();
        }
    }
}
