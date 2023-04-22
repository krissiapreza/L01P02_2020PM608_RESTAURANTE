using System.ComponentModel.DataAnnotations;

namespace L01P02_2020PM608_RESTAURANTE.Models {
    public class motoristas {
        [Key]
        [Display(Name = "Id motorista")]
        public int motoristaId { get; set; }

        [Display(Name = "Nombre del motorista")]
        public string? nombreMotorista { get; set; }
    }
}
