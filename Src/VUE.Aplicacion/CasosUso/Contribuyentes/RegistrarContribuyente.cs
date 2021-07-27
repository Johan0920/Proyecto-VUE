using MediatR;
using System.Threading;
using System.Threading.Tasks;
using VUE.Dominio.Modelos;
using VUE.Dominio.Repositorios;
using VUE.Infraestructura.Persistencia.InsightDatabase.Repositorios;

namespace VUE.Aplicacion.CasosUso
{
    public class RegistrarContribuyenteRequest:IRequest<RegistrarContribuyenteResult>
    {
        public Contribuyente contribuyente { get; set; }

    }

    public class RegistrarContribuyenteResult
    {
        public string Estado { get; set; }
        public string Mensaje { get; set; }
        public int IdContribuyente { get; set; }
    }
    public class RegistrarContribuyente : IRequestHandler<RegistrarContribuyenteRequest, RegistrarContribuyenteResult>
    {
        private readonly IContribuyenteRepositorio _context;

        public RegistrarContribuyente(IContribuyenteRepositorio  contribuyenteREpos)
        {
            _context = contribuyenteREpos;
        }

        public async Task<RegistrarContribuyenteResult> Handle(RegistrarContribuyenteRequest request, CancellationToken cancellationToken)
        {
            await Task.Delay(2000);
            var id=_context.RegistrarContribuyente(request.contribuyente );
            var registrarContribuyenteResult = new RegistrarContribuyenteResult()
            {
                Estado = "OK",
                Mensaje = "CONTRIBUYENTE REGISTRADO EXITOSAMENTE",
                IdContribuyente = await id
            };

            return registrarContribuyenteResult;
        }
    }
}
