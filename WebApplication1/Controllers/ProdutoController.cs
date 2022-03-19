using Desafio.Dominio.Dominio;
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

        public ProdutoController([FromBody] IProdutoServico _iprodutoServico)
        {
            this.iprodutoServico = _iprodutoServico;
        }

        [EnableCors]
        [HttpGet("ListarTudo")]
        public ActionResult<List<Produto>> ListarTudo()
        {
            try
            {
              List<Produto> listar = null;

              listar = iprodutoServico.ListarTudo();

              return listar;
            }
            catch(Exception)
            {
                throw;
            }
        }

        [EnableCors]
        [HttpPost("Adicionar")]
        public void Salvar([FromBody] Produto produto)
        {
            try
            {
                iprodutoServico.Adicionar(produto);
            }
            catch(Exception)
            {
                throw;
            }
        }

        [EnableCors]
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

        [EnableCors]
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
    }
}
