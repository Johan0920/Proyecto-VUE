using System;
using System.Collections.Generic;
using System.Text;
using VUE.Dominio.Repositorios;

namespace VUE.Infraestructura.Persistencia.InsightDatabase.Repositorios
{
    class EstablecimientoRepositorio : IEstablecimientoRepositorio
    {
        public void Registrar(string TipoDocumento, string NumeroDocumento, string Nombre, string CodigoDane, string Direccion, string FechaApertura, int Telefono, int ActividadGrabablePpal)
        {
            //ir a la bd a guardar
        }

        public void CambioNombre(string TipoDocumento, string NumeroDocumento, string NombreAnterior, string NombreNuevo, String Placa)
        {
            //ir a la bd a CambioNombre
        }

        public void CambioDireccionTelefono(string TipoDocumento, string NumeroDocumento, string Direccion, int Telefono, String Placa)
        {
            //ir a la bd a CambioDireccionTelefono
        }

        public void CambioActividad(string TipoDocumento, string NumeroDocumento, string FechaInicioActividad, int CodigoActividad, int TipoActividad, string DescripcionActividad, String Placa)
        {
            //ir a la bd a CambioActividad
        }

        public void Cancelacion(string TipoDocumento, string NumeroDocumento, string RazonSocial, string Nombre, String Placa)
        {
            //ir a la bd a Cancelacion
        }
    }
}
