using Desafio.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.Infraestruture.Repositorio.Interface
{
    public interface IProdutoRepositorio : IGenerciRepositorio<Produto>
    {
        Produto ListarProdutoPorNome(string nome);
    }
}
