using System;
using System.Collections.Generic;
using System.Text;

namespace VUE.Dominio.Modelos
{
    public class Contribuyente
    {
       
        public string RazonSocial { get; set; }
       
        public int TipoInscripcion { get; set; }
       
        public int TipoPersona { get; set; }
       
        public string TipoIdentificacion { get; set; }
       
        public int NumeroIdentificacion { get; set; }
       
        public int DigitoVerificacion { get; set; }
       
        public string RepresentanteLegal { get; set; }
       
        public String TipoDocRepresentante { get; set; }
       
        public int DocumentoRepresentante { get; set; }
       
        public String Suplente { get; set; }
       
        public string TipoDocSuplente { get; set; }
       
        public int DocumentoSuplente { get; set; }
       

        public int TelefonoContacto { get; set; }
       

        public int CodigoDane { get; set; }
       
        public String DireccionNotificaciones { get; set; }
       
        public String EmailComercial { get; set; }
        
        public String EmailNotificaciones { get; set; }
       
        public String CodigoActividadPrincipal { get; set; }
        public String CodigoActividadSec1 { get; set; }
        public String CodigoActividadSec2 { get; set; }
        public String CodigoActividadSec3 { get; set; }
       
       
        public DateTime FechaInicioActividades { get; set; }
       
        public int Regimen { get; set; }
       
        public String NaturalezaJuridica { get; set; }
    }
}
