using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLLDomain.Interfaces.Repositories;
using BLLDomain.Entities;
using Infrastructure.Repository;
using Application;
using ProvaTecnicaWebApplication.Models;
using AutoMapper;

namespace ProvaTecnicaWebApplication.Controllers
{
    public class HomeController : Controller
    {
        
        
        public ActionResult Index()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<Cliente, ClienteViewModel>());
            
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Salvar(ArquivosModel model)
        {
            Servico servico = new Servico();
            servico.GravarArquivoCliente(model.ArquivoClientes);
            servico.GravarArquivoProduto(model.ArquivoProdutos);
            return View("Index");
        }

        public ActionResult Clientes()
        {
           
            IEnumerable<ClienteViewModel> clienteView;
            Servico servico = new Servico();
            clienteView = Mapper.Map<IEnumerable<Cliente>, IEnumerable<ClienteViewModel>>(servico.GetAllClientes());
           
            return View(clienteView);
        }

        public ActionResult Produtos()
        {

            IEnumerable<ProdutoViewModel> produtosView;
            Servico servico = new Servico();
            produtosView = Mapper.Map<IEnumerable<Produto>, IEnumerable<ProdutoViewModel>>(servico.GetAllProdutos());

            return View(produtosView);
        }
    }
}