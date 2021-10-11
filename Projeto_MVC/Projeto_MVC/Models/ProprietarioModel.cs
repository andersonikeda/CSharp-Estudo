using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_MVC.Models
{
    [Table("Proprietario")]
    public class ProprietarioModel
    {
        [Key]
        public int ProprietarioId { get; set; }

        [MaxLength(50, ErrorMessage = "O campo deve ter no máximo {1} caracteres")]
        [MinLength(5, ErrorMessage = "O campo deve ter no mínimo {1} caracteres")]
        [Required(ErrorMessage = "Este campo é obrigatório!")]
        public string Nome { get; set; }

        [MaxLength(13, ErrorMessage = "O campo deve ter no máximo {1} caracteres")]
        [MinLength(13, ErrorMessage = "O campo deve ter no mínimo {1} caracteres")]
        [Required(ErrorMessage = "Este campo é obrigatório!")]
        public string Rg { get; set; }

        [MaxLength(14, ErrorMessage = "O campo deve ter no máximo {1} caracteres")]
        [MinLength(14, ErrorMessage = "O campo deve ter no mínimo {1} caracteres")]
        [Required(ErrorMessage = "Este campo é obrigatório!")]
        public string Cpf { get; set; }

        [MaxLength(50, ErrorMessage = "O campo deve ter no máximo {1} caracteres")]
        [MinLength(10, ErrorMessage = "O campo deve ter no mínimo {1} caracteres")]
        [Required(ErrorMessage = "Este campo é obrigatório!")]
        public string Rua { get; set; }

        [MaxLength(50, ErrorMessage = "O campo deve ter no máximo {1} caracteres")]
        [MinLength(10, ErrorMessage = "O campo deve ter no mínimo {1} caracteres")]
        [Required(ErrorMessage = "Este campo é obrigatório!")]
        public string Cidade { get; set; }
    }
}
