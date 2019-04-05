using System;
using System.Collections.Generic;
using System.Text;
using BLLDomain.Entities;

namespace BLLDomain.Interfaces.Repositories
{
    public interface IRepositoryCliente
    {
        IEnumerable<Cliente> GetAll();

        void Add(Cliente cliente);
    }
}
