using System;
using System.Collections.Generic;
using System.Text;
using BLLDomain.Entities;

namespace BLLDomain.Interfaces.Repositories
{
   public interface IRepositoryProduto
    {
        IEnumerable<Produto> GetAll();

        void Add(Produto produto);
    }
}
