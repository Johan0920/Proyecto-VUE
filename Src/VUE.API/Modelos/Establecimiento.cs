using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VUE.API.Modelos
{
    public class RegistrarEstablecimiento
    {
        [Required (ErrorMessage = "Tipo de documento es requerido")]
        public string tipoDocumento { get; set; }

        [Required(ErrorMessage = "Número de documento es requerido")]
        public string nroDocumento { get; set; }

        [Required(ErrorMessage = "Nombre es requerido")]
        public string nombre { get; set; }

        [Required(ErrorMessage = "Dirección es requerido")]
        public string direccion { get; set; }

        [Required(ErrorMessage = "Fecha apertura es requerida")]
        public string fechaApertura { get; set; }

        [Required(ErrorMessage = "Telefono es requerido")]
        public int telefono { get; set; }

        [Required(ErrorMessage = "Actividad grabable principal es requerido")]
        public int actividadGrabablePpal { get; set; }
    }

    public class CambioNombre
    {
        [Required(ErrorMessage = "Tipo de documento es requerido")]
        public string tipoDocumento { get; set; }

        [Required(ErrorMessage = "Número de documento es requerido")]
        public string nroDocumento { get; set; }

        [Required(ErrorMessage = "Nombre anterior es requerido")]
        public string nombreAnterior { get; set; }

        [Required(ErrorMessage = "Nombre nuevo es requerido")]
        public string nombreNuevo { get; set; }
    }

    public class CambioDireccionTelefono
    {
        [Required(ErrorMessage = "Tipo de documento es requerido")]
        public string tipoDocumento { get; set; }

        [Required(ErrorMessage = "Número de documento es requerido")]
        public string nroDocumento { get; set; }

        [Required(ErrorMessage = "La dirección es requerida")]
        public string direccion { get; set; }

        [Required(ErrorMessage = "Teléfono es requerido")]
        public string telefono { get; set; }
    }

    public class CambioActividad
    {
        [Required(ErrorMessage = "Tipo de documento es requerido")]
        public string tipoDocumento { get; set; }

        [Required(ErrorMessage = "Número de documento es requerido")]
        public string nroDocumento { get; set; }

        [Required(ErrorMessage = "Fecha inicio actividad es requerida")]
        public string fechaInicioActividad { get; set; }

        [Required(ErrorMessage = "Actividad grabable principal es requerido")]
        public int actividadGrabablePpal { get; set; }

        [Required(ErrorMessage = "Tipo actividad grabable principal es requerido")]
        public int tipoActividad { get; set; }

        [Required(ErrorMessage = "Descripción actividad grabable principal es requerido")]
        public string descripcionActividad { get; set; }
    }

    public class Cancelacion
    {
        [Required(ErrorMessage = "Tipo de documento es requerido")]
        public string tipoDocumento { get; set; }

        [Required(ErrorMessage = "Número de documento es requerido")]
        public string nroDocumento { get; set; }

        [Required(ErrorMessage = "La razón social es requerida")]
        public string razonSocial { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        public string nombre { get; set; }
    }
}
