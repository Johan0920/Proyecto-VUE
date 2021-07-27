using MediatR;
using System.Threading;
using System.Threading.Tasks;
using VUE.Dominio.Repositorios;

namespace VUE.Aplicacion.CasosUso
{
    public class CambioNombreEstablecimientoRequest : IRequest<CambioNombreEstablecimientoResult>
    {
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string NombreAnterior { get; set; }
        public string NombreNuevo { get; set; }
        public string Placa { get; set; }
    }

    public class CambioNombreEstablecimientoResult
    {
        public string Estado { get; set; }
        public string Mensaje { get; set; }
    }

    public class CambioNombreEstablecimiento : IRequestHandler<CambioNombreEstablecimientoRequest, CambioNombreEstablecimientoResult>
    {
        private IEstablecimientoRepositorio EstablecimientoRepositorio;

        public CambioNombreEstablecimiento(IEstablecimientoRepositorio establecimientoRepositorio)
        {
            EstablecimientoRepositorio = establecimientoRepositorio;
        }

        public async Task<CambioNombreEstablecimientoResult> Handle(CambioNombreEstablecimientoRequest request, CancellationToken cancellationToken)
        {
            //Antes validar si el Establecimiento existe --Preguntar donde se valida--

            EstablecimientoRepositorio.CambioNombre(request.TipoDocumento, request.NumeroDocumento, request.NombreAnterior, request.NombreNuevo, request.Placa);


            var cambioNombreEstablecimiento = new CambioNombreEstablecimientoResult()
            {
                Estado = "OK",
                Mensaje = "Nombre modificado exitosamente"
            };

            return cambioNombreEstablecimiento;
        }
    }
}
