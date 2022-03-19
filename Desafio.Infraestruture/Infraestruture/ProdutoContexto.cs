using Desafio.Dominio.Dominio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.Infraestruture.Infraestruture
{
    public class ProdutoContexto : DbContext
    {

        public ProdutoContexto()
        {

        }

        public ProdutoContexto(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Produto> Produto { get; set; }
    }
}
