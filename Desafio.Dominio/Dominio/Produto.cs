using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.Dominio.Dominio
{
    [Table("tb_Produto")]
    public class Produto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o estoque")]
        public string Estoque { get; set; }

        [Required(ErrorMessage = "Informe o valor")]
        public int Valor { get; set; }
    }
}
