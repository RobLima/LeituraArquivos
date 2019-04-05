using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLLDomain.Interfaces.Repositories;
using BLLDomain.Entities;
using Infrastructure.Repository;
using System.Web;
using System.IO;
namespace Application
{
    public class Servico
    {
        private IRepositoryCliente _clienteRepositoryInterface;
        private IRepositoryProduto _produtoRepositoryProduto;
        public Servico ()
        {
            _clienteRepositoryInterface = new ClienteRepository();
            _produtoRepositoryProduto = new ProdutoRepository();
        }

        public IEnumerable<Cliente> GetAllClientes()
        {
            return _clienteRepositoryInterface.GetAll();
        }

        public IEnumerable<Produto> GetAllProdutos()
        {
            return _produtoRepositoryProduto.GetAll();
        }

        private string ConvertFileToString (HttpPostedFileBase arquivo)
        {
            string texto = string.Empty;
            using (BinaryReader b = new BinaryReader(arquivo.InputStream))
            {
                byte[] binData = b.ReadBytes(arquivo.ContentLength);
                texto = System.Text.Encoding.UTF8.GetString(binData);
            }
            return texto;
        }

        public void GravarArquivoCliente(HttpPostedFileBase arquivo)
        {
            string result = ConvertFileToString(arquivo);

            string[] clienteLinhas  = result.Split(';');
            
          
            foreach (string clienteLinha in clienteLinhas)
            {
                string[] colunas = clienteLinha.Split(',');
                Cliente cliente = new Cliente();
                cliente.ClienteId = Convert.ToInt16(colunas[0]);
                cliente.Nome = colunas[1];
                cliente.Sobrenome = colunas[2];

                string[] Datanascimento = colunas[3].Split('/');
                cliente.DataNascimento = new DateTime(Convert.ToInt16(Datanascimento[2]), Convert.ToInt16(Datanascimento[1]), Convert.ToInt16(Datanascimento[0]));
                cliente.Sexo = colunas[4];
                cliente.Email = colunas[5];

                if (colunas[6] == "true")
                    cliente.Ativo = true;
                else
                    cliente.Ativo = false;

                _clienteRepositoryInterface.Add(cliente);
            }
        }

        public void GravarArquivoProduto(HttpPostedFileBase arquivo)
        {
            string result = ConvertFileToString(arquivo);
            string[] produtoLinhas = result.Split(';');


            foreach (string produtoLinha in produtoLinhas)
            {
                string[] colunas = produtoLinha.Split(',');
                Produto produto = new Produto();
                produto.ProdutoId = Convert.ToInt16(colunas[0]);
                produto.ClienteId = Convert.ToInt16(colunas[1]);
                produto.Nome = colunas[2];

                _produtoRepositoryProduto.Add(produto);
            }
        }
    }
}
