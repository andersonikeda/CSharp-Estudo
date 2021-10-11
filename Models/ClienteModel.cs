using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVCVendasApp.Models
{
    [Table("Clientes")]
    public class ClienteModel
    {
        [Key]
        public int ClienteId { get; set; }

        [MaxLength(50, ErrorMessage = "O Nome deve ter no maximo {0} caracteres")]
        public string Nome { get; set; }

        [MaxLength(80, ErrorMessage = "O Email deve ter no maximo {0} caracteres")]
        public string Email { get; set; }

        public ICollection<VendaModel> Vendas { get; set; }
    }
}