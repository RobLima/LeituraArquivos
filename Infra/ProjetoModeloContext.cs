using System;
using System.Data.Entity;


namespace Infra
{
    public class ProjetoModeloContext: DbContext 
    {
        public ProjetoModeloContext() :base("stringConexao")
        {

        }
    }
}
