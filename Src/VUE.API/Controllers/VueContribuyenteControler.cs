using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VUE.API.Models;
using VUE.Aplicacion.CasosUso;
using VUE.Aplicacion.CasosUso.Contribuyentes;

namespace VUE.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VueContribuyenteControler : ControllerBase
    {
        private readonly IMediator Mediator;
        private readonly IMapper Mapeador;

        public VueContribuyenteControler(IMediator mediator, IMapper mapeador)
        {
            Mediator = mediator;
            Mapeador = mapeador;
        }
        [HttpPost]
        public async Task<IActionResult> RegistrarContribuyente ([FromBody] ContribuyenteModel contribuyente)
        {
            var registrarContribuyenteRequest = new RegistrarContribuyenteRequest();
            var existeContribuyente = new ExisteContribuyenteRequest();
            Mapeador.Map(contribuyente, registrarContribuyenteRequest);
            existeContribuyente.IdContribuyente = registrarContribuyenteRequest.contribuyente.NumeroIdentificacion.ToString();
            var resultadoBusqueda = await Mediator.Send(existeContribuyente);
            if (!resultadoBusqueda.Existe)
            {
                var resultado = await Mediator.Send(registrarContribuyenteRequest);
                return Ok(resultado);
            }
            else
            {
                resultadoBusqueda.Estado = "Error";
                resultadoBusqueda.Mensaje = "EL CONTRIBUYENTE CON IDENTIFICACION " + existeContribuyente.IdContribuyente.ToString()+ " YA EXISTE";
                resultadoBusqueda.Existe = false;
                return BadRequest(resultadoBusqueda);
            }
        }

        [HttpPost]
        public async Task<IActionResult> ActualizarContribuyente([FromBody] ContribuyenteModel contribuyente)
        {
            var existeContribuyente = new ExisteContribuyenteRequest();
            var actualizarContribuyente = new ActualizarContribuyenteRequest();
            Mapeador.Map(contribuyente, actualizarContribuyente);
            existeContribuyente.IdContribuyente = actualizarContribuyente.contribuyente.NumeroIdentificacion.ToString();
            var resultadoBusqueda = await Mediator.Send(existeContribuyente);
            if ( resultadoBusqueda.Existe)
            {
                var resultado = await Mediator.Send(actualizarContribuyente);
                if (resultado.Respuesta)
                {
                    return Ok(resultado);
                }
                else
                {
                    resultado.Estado = "Error";
                    resultado.Mensaje = "Error al actualizar contribuyente";
                    resultado.Respuesta = false;
                    return BadRequest(resultado);

                }
            }
            else
            {
                resultadoBusqueda.Estado = "Error";
                resultadoBusqueda.Mensaje="NO EXISTE CONTRIBUYENTE REGISTRADO CON NUMERO DE IDENTIFICACION " + actualizarContribuyente.contribuyente.NumeroIdentificacion.ToString();
                resultadoBusqueda.Existe = false;
                return BadRequest(resultadoBusqueda);
            }
           
        }

     
    }
}
