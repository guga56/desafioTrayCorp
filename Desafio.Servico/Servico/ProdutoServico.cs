using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desafio.Dominio.Dominio;
using Desafio.Infraestruture.Repositorio.Interface;

namespace Desafio.Servico.Servico
{
    public class ProdutoServico
    {
        private IProdutoRepositorio iprodutoRepositorio;

        public void Adicionar(Produto produto)
        {
            iprodutoRepositorio.Adicionar(produto);
        }

        public List<Produto> ListarTudo()
        {
            return iprodutoRepositorio.ObterTodos();
        }

        public void Delete(int idProduto)
        {
            iprodutoRepositorio.Delertar(idProduto);
        }

        public void Update(Produto produto)
        {
            iprodutoRepositorio.Atualizar(produto);
        }

        public Produto BuscarProNome(string nome)
        {
            return iprodutoRepositorio.Buscar(nome);
        }
    }
}
