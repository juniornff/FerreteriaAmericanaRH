using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FerreteriaAmericanaRH.Model
{
    [Table("Encabezado")]
    public class Encabezado
    {
        [Key]
        [Required]
        public int EncabazadoID { get; set; }
        [Required]
        [MaxLength(2)]
        public string TipoAutodeterminacion { get; set; }
        [Required]
        [MaxLength(9)]
        public string RNC { get; set; }
        [Required]
        public DateTime Periodo { get; set; }
        [Required]
        public List<Detalle> Detalles { get; set; }
    }
}