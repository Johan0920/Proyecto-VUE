using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace VUE.API.Models
{
    public class ContribuyenteModel
    {
        [Required(ErrorMessage ="Dato requerido")]
        public string RazonSocial { get; set; }
        [Required(ErrorMessage = "Dato requerido")]
        public int TipoInscripcion { get; set; }
        [Required(ErrorMessage = "Dato requerido")]
        public int TipoPersona { get; set; }
        [Required(ErrorMessage = "Dato requerido")]
        public string TipoIdentificacion { get; set; }
        [Required(ErrorMessage = "Dato requerido")]
        public int NumeroIdentificacion { get; set; }
        [Required(ErrorMessage = "Dato requerido")]
        public int DigitoVerificacion { get; set; }
        [Required(ErrorMessage = "Dato requerido")]
        public string RepresentanteLegal { get; set; }
        [Required(ErrorMessage = "Dato requerido")]
        public String TipoDocRepresentante { get; set; }
        [Required(ErrorMessage = "Dato requerido")]
        public int DocumentoRepresentante { get; set; }
        [Required(ErrorMessage = "Dato requerido")]
        public String Suplente { get; set; }
        [Required(ErrorMessage = "Dato requerido")]
        public string TipoDocSuplente { get; set; }
        [Required(ErrorMessage = "Dato requerido")]
        public int DocumentoSuplente { get; set; }
        [Required(ErrorMessage = "Dato requerido"), MaxLength]
        
        public int TelefonoContacto { get; set; }
        [Required(ErrorMessage = "Dato requerido")]
        public int CodigoDane { get; set; }
        [Required(ErrorMessage = "Dato requerido")]
        public String DireccionNotificaciones { get; set; }
        [Required(ErrorMessage = "Dato requerido")]
        public String EmailComercial { get; set; }
        [Required(ErrorMessage = "Dato requerido")]
        public String EmailNotificaciones { get; set; }
        [Required(ErrorMessage = "Dato requerido")]
        public String CodigoActividadPrincipal { get; set; }
        [Required(ErrorMessage = "Dato requerido")]
        public String CodigoActividadSec1 { get; set; }
        [Required(ErrorMessage = "Dato requerido")]
        public String CodigoActividadSec2 { get; set; }
        [Required(ErrorMessage = "Dato requerido")]
        public String CodigoActividadSec3 { get; set; }
        [Required(ErrorMessage = "Dato requerido")]
        [DataType(DataType.DateTime)]
        public DateTime FechaInicioActividades { get; set; }
        [Required(ErrorMessage = "Dato requerido")]
        public int Regimen { get; set; }
        [Required(ErrorMessage = "Dato requerido")]
        public String NaturalezaJuridica { get; set; }
    }
}
