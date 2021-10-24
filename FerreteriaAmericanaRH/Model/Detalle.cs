using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FerreteriaAmericanaRH.Model
{
    [Table("Detalles")]
    public class Detalle
    {
        [Key]
        [Required]
        public int DetalleID { get; set; }
        //[ForeignKey("EncabazadoID")]
        //public int EncabezadoID { get; set; }
        [Required]
        [MaxLength(3)]
        public string TipoDocumento { get; set; }
        [Required]
        [MaxLength(11)]
        public string Documento { get; set; }
        [Required]
        [MaxLength(4)]
        public string CodigoNomina { get; set; }
        [Required]
        [MaxLength(60)]
        public string Empleado { get; set; }
    }
}