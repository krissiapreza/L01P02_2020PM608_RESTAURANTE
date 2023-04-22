using System.ComponentModel.DataAnnotations;

namespace L01P02_2020PM608_RESTAURANTE.Models {
    public class pedidos {
        [Key]
        [Display(Name = "Id Pedido")]
        public int pedidoId { get; set; }

        [Display(Name = "Id motorista")]
        public int motoristaId { get; set; }

        [Display(Name = "Id cliente")]
        public int clienteId { get; set; }

        [Display(Name = "Id plato")]
        public int platoId { get; set; }

        [Display(Name = "cantidad")]
        public int cantidad { get; set; }

        [Display(Name = "Precio")]
        public decimal? precio { get; set; }

    }
}
