using System;
using System.Collections.Generic;
using System.Text;

namespace VUE.Dominio.Repositorios
{
    public interface IEstablecimientoRepositorio
    {
        void Registrar(string TipoDocumento, string NumeroDocumento, string Nombre, string CodigoDane, string Direccion, string FechaApertura, int Telefono, int ActividadGrabablePpal);
        
        void CambioNombre(string TipoDocumento, string NumeroDocumento, string NombreAnterior, string NombreNuevo, String Placa);

        void CambioDireccionTelefono(string TipoDocumento, string NumeroDocumento, string Direccion, int Telefono, String Placa);
        
        void CambioActividad(string TipoDocumento, string NumeroDocumento, string FechaInicioActividad, int CodigoActividad, int TipoActividad, string DescripcionActividad, String Placa);

        void Cancelacion(string TipoDocumento, string NumeroDocumento, string RazonSocial, string Nombre, String Placa);
    }
}
