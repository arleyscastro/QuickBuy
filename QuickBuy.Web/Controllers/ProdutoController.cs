using System;
using Microsoft.AspNetCore.Mvc;
using QuickBuy.Dominio.Contratos;
using QuickBuy.Dominio.Entidades;

namespace QuickBuy.Web.Controllers
{
    [Route("api/[controller]")]
    public class ProdutoController: Controller
    {
        private readonly IProdutoRepositorio _produtoRepositorio;
        public ProdutoController(IProdutoRepositorio produtoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_produtoRepositorio.ObterTodos());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return BadRequest(e.ToString());
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody]Produto produto)
        {
            try
            {
                _produtoRepositorio.Adicioar(produto);
                return Created("api/produto", produto);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return BadRequest(e.ToString());
            }
        }
    }
}