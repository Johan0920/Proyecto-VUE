using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VUE.Aplicacion.CasosUso;
using VUE.Dominio.Modelos;

namespace VUE.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VueController : ControllerBase
    {
        private readonly IMediator Mediator;
        private readonly IMapper Mapeador;

        public VueController(IMediator mediator, IMapper mapeador)
        {
            Mediator = mediator;
            Mapeador = mapeador; 
        }

        [HttpPost]
        public async Task<IActionResult> RegistrarContribuyente([FromBody] Contribuyente contribuyente)
        {
            var registrarContribuyenteRequest = new RegistrarContribuyenteRequest();
            Mapeador.Map(contribuyente, registrarContribuyenteRequest);
            var resultado = await Mediator.Send(registrarContribuyenteRequest);
            return Ok(resultado);
        }
    }
}
