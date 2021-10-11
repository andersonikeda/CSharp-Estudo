using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_MVC.Models
{
    [Table("Especie")]
    public class EspecieModel
    {
        [Key]
        public int EspecieId { get; set; }

        [MaxLength(50, ErrorMessage = "O campo deve ter no máximo {1} caracteres")]
        [MinLength(5, ErrorMessage = "O campo deve ter no mínimo {1} caracteres")]
        [Required(ErrorMessage = "Este campo é obrigatório!")]
        public string Nome { get; set; }
    }
}
