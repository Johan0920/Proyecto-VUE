using MediatR;
using System.Threading;
using System.Threading.Tasks;
using VUE.Dominio.Repositorios;

namespace VUE.Aplicacion.CasosUso
{
    public class CancelacionEstablecimientoRequest : IRequest<CancelacionEstablecimientoResult>
    {
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string RazonSocial { get; set; }
        public string Nombre { get; set; }
        public string Placa { get; set; }

    }

    public class CancelacionEstablecimientoResult
    {
        public string Estado { get; set; }
        public string Mensaje { get; set; }
    }

    public class CancelacionEstablecimiento : IRequestHandler<CancelacionEstablecimientoRequest, CancelacionEstablecimientoResult>
    {
        private IEstablecimientoRepositorio EstablecimientoRepositorio;

        public CancelacionEstablecimiento(IEstablecimientoRepositorio establecimientoRepositorio)
        {
            EstablecimientoRepositorio = establecimientoRepositorio;
        }

        public async Task<CancelacionEstablecimientoResult> Handle(CancelacionEstablecimientoRequest request, CancellationToken cancellationToken)
        {
            //Antes validar si el Establecimiento existe --Preguntar donde se valida--

            EstablecimientoRepositorio.Cancelacion(request.TipoDocumento, request.NumeroDocumento, request.RazonSocial, request.Nombre, request.Placa);

            var cancelacionEstablecimiento = new CancelacionEstablecimientoResult()
            {
                Estado = "OK",
                Mensaje = "Establecimiento cancelado exitosamente"
            };

            return cancelacionEstablecimiento;
        }
    }
}
