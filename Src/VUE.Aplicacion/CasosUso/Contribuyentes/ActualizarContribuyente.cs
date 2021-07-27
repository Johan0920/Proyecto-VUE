using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VUE.Dominio.Modelos;
using VUE.Dominio.Repositorios;

namespace VUE.Aplicacion.CasosUso.Contribuyentes
{
    public class ActualizarContribuyenteResult
    {
        public string Estado { get; set; }
        public string Mensaje { get; set; }
        public Boolean Respuesta { get; set; }
    }

    public class ActualizarContribuyenteRequest:IRequest<ActualizarContribuyenteResult>
    {
        public Contribuyente contribuyente { get; set; }
    }
   

   public  class ActualizarContribuyente: IRequestHandler<ActualizarContribuyenteRequest, ActualizarContribuyenteResult>
    {
        private readonly IContribuyenteRepositorio repositorio;

        public ActualizarContribuyente(IContribuyenteRepositorio contribuyenteREpos)
        {
            repositorio = contribuyenteREpos;
        }
       

        public async Task<ActualizarContribuyenteResult> Handle(ActualizarContribuyenteRequest request, CancellationToken cancellationToken)
        {
            var boolResp = repositorio.ActualizarContribuyente(request.contribuyente);
            var updateContribuyenteResult = new ActualizarContribuyenteResult()
            {
                Estado = "OK",
                Mensaje = "CONTRIBUYENTE ACTUALIZADO EXITOSAMENTE",
                Respuesta = await boolResp
            };
            return updateContribuyenteResult;
        }
    }
}
