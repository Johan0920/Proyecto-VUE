using MediatR;
using System.Threading;
using System.Threading.Tasks;
using VUE.Dominio.Repositorios;

namespace VUE.Aplicacion.CasosUso
{
    public class RegistrarEstablecimientoRequest : IRequest<RegistrarEstablecimientoResult>
    {
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string Nombre { get; set; }
        public string CodigoDane { get; set; }
        public string Direccion { get; set; }
        public string FechaApertura { get; set; }
        public int Telefono { get; set; }
        public int ActividadGrabablePpal { get; set; }
    }

    public class RegistrarEstablecimientoResult
    {
        public string Estado { get; set; }
        public string Mensaje { get; set; }
    }
    public class RegistrarEstablecimiento : IRequestHandler<RegistrarEstablecimientoRequest, RegistrarEstablecimientoResult>
    {
        private IEstablecimientoRepositorio EstablecimientoRepositorio;

        public RegistrarEstablecimiento(IEstablecimientoRepositorio establecimientoRepositorio)
        {
            EstablecimientoRepositorio = establecimientoRepositorio;
        }

        public async Task<RegistrarEstablecimientoResult> Handle(RegistrarEstablecimientoRequest request, CancellationToken cancellationToken)
        {
            //Antes validar si el Establecimiento existe --Preguntar donde se valida--

            EstablecimientoRepositorio.Registrar(request.TipoDocumento, request.NumeroDocumento, request.Nombre, request.CodigoDane, request.Direccion, request.FechaApertura, request.Telefono, request.ActividadGrabablePpal);
            
            var registrarEstablecimientoResult = new RegistrarEstablecimientoResult()
            {
                Estado = "OK",
                Mensaje = "Establecimiento registrado exitosamente"
            };

            return registrarEstablecimientoResult;
        }
    }
}
