using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Desafio.Dominio.Dominio;
using Desafio.Infraestruture.Repositorio.Interface;
using Desafio.Servico.Servico.Interface;

namespace Desafio.Servico.Servico
{
    public class ProdutoServico : IProdutoServico
    {
        private IProdutoRepositorio iprodutoRepositorio;

        public void Adicionar(Produto produto)
        {
            iprodutoRepositorio.Adicionar(produto);
        }

        public Produto BuscarProNome(string nome)
        {
            return iprodutoRepositorio.Buscar(nome);
        }

        public void Delete(int idProduto)
        {
            iprodutoRepositorio.Deletar(idProduto);
        }

        public List<Produto> ListarTudo()
        {
            return iprodutoRepositorio.ObterTodos();
        }

        public void Update(Produto produto)
        {
            iprodutoRepositorio.Atualizar(produto);
        }
    }
}
