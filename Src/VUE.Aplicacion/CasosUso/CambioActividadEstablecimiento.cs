using MediatR;
using System.Threading;
using System.Threading.Tasks;
using VUE.Dominio.Repositorios;

namespace VUE.Aplicacion.CasosUso
{
    public class CambioActividadEstablecimientoRequest : IRequest<CambioActividadEstablecimientoResult>
    {
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string FechaInicioActividad { get; set; }
        public int CodigoActividad { get; set; }
        public int TipoActividad { get; set; }
        public string DescripcionActividad { get; set; }
        public string Placa { get; set; }
    }

    public class CambioActividadEstablecimientoResult
    {
        public string Estado { get; set; }
        public string Mensaje { get; set; }
    }

    public class CambioActividadEstablecimiento : IRequestHandler<CambioActividadEstablecimientoRequest, CambioActividadEstablecimientoResult>
    {
        private IEstablecimientoRepositorio EstablecimientoRepositorio;

        public CambioActividadEstablecimiento(IEstablecimientoRepositorio establecimientoRepositorio)
        {
            EstablecimientoRepositorio = establecimientoRepositorio;
        }

        public async Task<CambioActividadEstablecimientoResult> Handle(CambioActividadEstablecimientoRequest request, CancellationToken cancellationToken)
        {
            //Antes validar si el Establecimiento existe --Preguntar donde se valida--

            EstablecimientoRepositorio.CambioActividad(request.TipoDocumento, request.NumeroDocumento, request.FechaInicioActividad, request.CodigoActividad, request.TipoActividad, request.DescripcionActividad, request.Placa);

            var cambioActividadEstablecimiento = new CambioActividadEstablecimientoResult()
            {
                Estado = "OK",
                Mensaje = "Actividad modificada exitosamente"
            };

            return cambioActividadEstablecimiento;
        }
    }
}
