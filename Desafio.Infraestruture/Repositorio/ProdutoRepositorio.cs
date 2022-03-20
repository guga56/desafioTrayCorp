using Desafio.Dominio.Dominio;
using Desafio.Infraestruture.Infraestruture;
using Desafio.Infraestruture.Repositorio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.Infraestruture.Repositorio
{
    public class ProdutoRepositorio : GenericRepositorio<Produto>, IProdutoRepositorio
    {
        private readonly ProdutoContexto _db;

        public IEnumerable<Produto> Buscar(object id)
        {
            throw new NotFiniteNumberException();
        }

        public Produto ListarProdutoPorNome(string nome)
        {
            return _db.Produtos.Where(a => a.Nome == nome).FirstOrDefault();
        }
    }
}
