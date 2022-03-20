using Desafio.Dominio.Dominio;
using Desafio.Infraestruture.Infraestruture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.Servico.Negocio
{
    public class ProdutoNegocio
    {
        private readonly ProdutoContexto contexto;

        public Produto ValorPositivo(Produto produto)
        {

            if(produto.Valor > 0)
            {
                contexto.Produtos.Add(produto);
            }
            else
            {
                throw new Exception("Valor não pode ser negativo");
            }

            return produto;
        }
    }
}
