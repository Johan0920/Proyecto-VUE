using MediatR;
using System.Threading;
using System.Threading.Tasks;
using VUE.Dominio.Repositorios;

namespace VUE.Aplicacion.CasosUso
{
    public class CambioDireccionTelefonoEstablecimientoRequest : IRequest<CambioDireccionTelefonoEstablecimientoResult>
    {
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public string Placa { get; set; }
    }

    public class CambioDireccionTelefonoEstablecimientoResult
    {
        public string Estado { get; set; }
        public string Mensaje { get; set; }
    }

    public class CambioDireccionTelefonoEstablecimiento : IRequestHandler<CambioDireccionTelefonoEstablecimientoRequest, CambioDireccionTelefonoEstablecimientoResult>
    {
        private IEstablecimientoRepositorio EstablecimientoRepositorio;

        public CambioDireccionTelefonoEstablecimiento(IEstablecimientoRepositorio establecimientoRepositorio)
        {
            EstablecimientoRepositorio = establecimientoRepositorio;
        }

        public async Task<CambioDireccionTelefonoEstablecimientoResult> Handle(CambioDireccionTelefonoEstablecimientoRequest request, CancellationToken cancellationToken)
        {
            //Antes validar si el Establecimiento existe --Preguntar donde se valida--

            EstablecimientoRepositorio.CambioDireccionTelefono(request.TipoDocumento, request.NumeroDocumento, request.Direccion, request.Telefono, request.Placa);

            var cambioDireccionTelefonoEstablecimiento = new CambioDireccionTelefonoEstablecimientoResult()
            {
                Estado = "OK",
                Mensaje = "Dirección y teléfono modificados exitosamente"
            };

            return cambioDireccionTelefonoEstablecimiento;
        }
    }
}
