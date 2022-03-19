using Desafio.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.Servico.Servico.Interface
{
    public interface IProdutoServico
    {
        void Adicionar(Produto produto);

        List<Produto> ListarTudo();

        void Delete(int idProduto);

        void Update(Produto produto);

        Produto BuscarProNome(string nome);
    }
}
