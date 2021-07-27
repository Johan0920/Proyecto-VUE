using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace VUE.Aplicacion.CasosUso
{
    public class RegistrarContribuyenteRequest:IRequest<RegistrarContribuyenteResult>
    {
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string Nombres { get; set; }

    }

    public class RegistrarContribuyenteResult
    {
        public string Estado { get; set; }
        public string Mensaje { get; set; }
    }
    public class RegistrarContribuyente : IRequestHandler<RegistrarContribuyenteRequest, RegistrarContribuyenteResult>
    {
        
        public RegistrarContribuyente()
        {
            
        }

        public async Task<RegistrarContribuyenteResult> Handle(RegistrarContribuyenteRequest request, CancellationToken cancellationToken)
        {
            
            var registrarContribuyenteResult = new RegistrarContribuyenteResult()
            {
                Estado = "OK",
                Mensaje = "CONTRIBUYENTE REGISTRADO EXITOSAMENTE"
            };

            return registrarContribuyenteResult;
        }
    }
}
