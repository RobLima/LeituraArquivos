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
    public class ClienteRepository : IRepositoryCliente

    {
        protected Contexto Db = new Contexto();
        public IEnumerable<Cliente> GetAll()
        {
            return Db.Set<Cliente>().ToList();
        }




        public void AddList(List<Cliente> lstCliente)
        {
            Db.Clientes.AddRange(lstCliente);
            Db.SaveChanges();
        }

     

    }
}
