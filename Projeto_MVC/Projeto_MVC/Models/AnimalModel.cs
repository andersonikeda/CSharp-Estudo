using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_MVC.Models
{
    [Table("Animal")]
    public class AnimalModel
    {
        [Key]
        public int AnimalId { get; set; }

        [MaxLength(50, ErrorMessage = "O campo deve ter no máximo {1} caracteres")]
        [MinLength(5, ErrorMessage = "O campo deve ter no mínimo {1} caracteres")]
        [Required(ErrorMessage = "Este campo é obrigatório!")]
        public string Nome { get; set; }

        [Column(TypeName = "decimal(5,2)")]
        [Required(ErrorMessage = "Este campo é obrigatório!")]
        public decimal Peso { get; set; }

        [Column(TypeName = "decimal(3,2)")]
        [Required(ErrorMessage = "Este campo é obrigatório!")]
        public decimal altura { get; set; }

        [Column(TypeName = "decimal(3,2)")]
        [Required(ErrorMessage = "Este campo é obrigatório!")]
        public decimal Comprimento { get; set; }

        [MaxLength(50, ErrorMessage = "O campo deve ter no máximo {1} caracteres")]
        [MinLength(5, ErrorMessage = "O campo deve ter no mínimo {1} caracteres")]
        [Required(ErrorMessage = "Este campo é obrigatório!")]
        public string Pedigree { get; set; }

        [ForeignKey("Especie")]
        public int EspecieId { get; set; }

        public EspecieModel Especie { get; set; }

        [ForeignKey("Proprietario")]
        public int ProprietarioId { get; set; }

        public ProprietarioModel Proprietario { get; set; }
    }
}
