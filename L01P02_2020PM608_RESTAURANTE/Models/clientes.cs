using System.ComponentModel.DataAnnotations;

namespace L01P02_2020PM608_RESTAURANTE.Models {
    public class clientes {
        [Key]
        [Display(Name = "Id Cliente")]
        public int clienteId { get; set; }

        [Display(Name = "Nombre del cliente")]
        public string? nombreCliente { get; set; }

        [Display(Name = "Direccion")]
        public string? direccion { get; set; }
    }
}
