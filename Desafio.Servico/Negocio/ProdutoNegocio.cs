using Desafio.Dominio.Dominio;
using Desafio.Infraestruture.Infraestruture;
using Desafio.Infraestruture.Repositorio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.Servico.Negocio
{
    public class ProdutoNegocio
    {
        private readonly IProdutoRepositorio repositorio;

        public Produto ValorPositivo(Produto produto)
        {
            if(produto.Valor > 0)
            {
                repositorio.Adicionar(produto);
            }
            else
            {
                throw new Exception("Valor não pode ser negativo");
            }

            return produto;
        }
    }
}
