using Desafio.Dominio.Dominio;
using Desafio.Servico.Negocio;
using Desafio.Servico.Servico.Interface;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoServico iprodutoServico;

        public ProdutoController(IProdutoServico iprodutoServico)
        {
            this.iprodutoServico = iprodutoServico;
        }

        [HttpGet("ListarTudo")]
        public ActionResult<List<Produto>> ListarTudo()
        {
            try
            {
              List<Produto> listar = new List<Produto>();
              
              listar = iprodutoServico.ListarTudo().OrderBy(x => x.Nome).ToList();

              return listar;
            }
            catch(Exception)
            {
                throw;
            }
        }

        [HttpPost("Adicionar")]
        public void Adicionar([FromBody] Produto produto)
        {
            try
            {
                ProdutoNegocio produtoNegocio = new ProdutoNegocio();
                produtoNegocio.ValorPositivo(produto);
                iprodutoServico.Adicionar(produto);
            }
            catch(Exception)
            {
                throw;
            }
        }

        [HttpPut("{Update}/{produto}")]
        public void Update([FromBody] Produto produto)
        {
            try
            {
                iprodutoServico.Update(produto);
            }
            catch(Exception)
            {
                throw;
            }
        }

        [HttpDelete("{Deletar}/{idproduto}")]
        public void Deletar([FromForm] int idproduto)
        {
            try
            {
                iprodutoServico.Delete(idproduto);
            }
            catch(Exception)
            {
                throw;
            }
        }

        [HttpGet("{BuscarPorNome}/{nome}")]
        public ActionResult<Produto> BuscarPorNome(string nome)
        {
            try
            {
                var nomeBuscar = iprodutoServico.BuscarProNome(nome);

                return nomeBuscar;
            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}
