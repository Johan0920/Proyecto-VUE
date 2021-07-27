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
    public class BuscarContribuyenteResult
    {
        public string Estado { get; set; }
        public Contribuyente Contribuyente { get; set; }
    }

    public class ExisteContribuyenteResult
    {
        public string Estado { get; set; }
        public string Mensaje { get; set; }
        public bool Existe { get; set; }
    }

    public class BuscarContribuyenteRequest:IRequest<BuscarContribuyenteResult>
    {
        public string IdContribuyente { get; set; }
    }

    public class ExisteContribuyenteRequest : IRequest<ExisteContribuyenteResult>
    {
        public string IdContribuyente { get; set; }
    }


    public class BuscarContribuyente : IRequestHandler<BuscarContribuyenteRequest, BuscarContribuyenteResult>
    {
        private readonly IContribuyenteRepositorio repositorio;

        public BuscarContribuyente(IContribuyenteRepositorio contribuyenteREpos)
        {
            repositorio = contribuyenteREpos;
        }
        
        
        public async Task<BuscarContribuyenteResult> Handle(BuscarContribuyenteRequest request, CancellationToken cancellationToken)
        {
            var busquedaResp = repositorio.BuscarContribuyenteporId(request.IdContribuyente);
            var buscarContribuyente = new BuscarContribuyenteResult()
            {
                Estado = "OK",
                Contribuyente = await busquedaResp
            };
            return buscarContribuyente;
        }
    }

    public class ExisteContribuyente : IRequestHandler<ExisteContribuyenteRequest, ExisteContribuyenteResult>
    {
        private readonly IContribuyenteRepositorio repositorio;

        public ExisteContribuyente(IContribuyenteRepositorio contribuyenteREpos)
        {
            repositorio = contribuyenteREpos;
        }


          public async Task<ExisteContribuyenteResult> Handle(ExisteContribuyenteRequest request, CancellationToken cancellationToken)
        {
            var existe = repositorio.ExisteContribuyente(request.IdContribuyente);
            var existeContribuyenteResult = new ExisteContribuyenteResult()
            {
                Estado = "OK",
                Mensaje= "EXISTE CONTRIBUYENTE EN BASE DE DATOS",
                Existe = await existe
            };
            return existeContribuyenteResult;
        }
    }


}
