using Insight.Database;
using Insight.Database.Structure;
using Microsoft.Ajax.Utilities;
using Microsoft.Extensions.Configuration;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VUE.Dominio.Modelos;
using VUE.Dominio.Repositorios;

namespace VUE.Infraestructura.Persistencia.InsightDatabase.Repositorios
{
    public class ContribuyenteRepositorio : IContribuyenteRepositorio
    {
        private readonly string CadenaConexion;
        public ContribuyenteRepositorio (IConfiguration configuration)
        {
            CadenaConexion = configuration.GetConnectionString("MateoConnectionString");
        }
        private IDbConnection Conexion
        {
            get
            {
                return new OracleConnection(CadenaConexion)
                {
                    KeepAlive = true
                };

            }
        }
        public async  Task<Boolean> ActualizarContribuyente(Contribuyente contribuyente)
        {
            
            var resultado = await Conexion.ExecuteAsync("ACTUALIZAR_CONTRIBUYENTE",
                new
                {
              RAZONSOCIAL=                      contribuyente.RazonSocial,
              TIPOINSCRIPCION =                 contribuyente.TipoInscripcion ,
              TIPOPERSONA =                     contribuyente.TipoPersona ,
              TIPOIDENTIFICACION =              contribuyente.TipoIdentificacion ,
              NUMEROIDENTIFICACION =            contribuyente.NumeroIdentificacion ,
              DIGITOVERIFICACION =              contribuyente.DigitoVerificacion ,
              REPRESENTANTELEGAL =              contribuyente.RepresentanteLegal ,
              TIPODOCREPRESENTANTE =            contribuyente.TipoDocRepresentante ,
              DOCUMENTOREPRESENTANTE =          contribuyente.DocumentoRepresentante ,
              SUPLENTE =                        contribuyente.Suplente ,
              TIPODOCSUPLENTE =                 contribuyente.TipoDocSuplente ,
              DOCUMENTOSUPLENTE =               contribuyente.DocumentoSuplente ,
              TELEFONOCONTACTO =                contribuyente.TelefonoContacto ,
              CODIGODANE =                      contribuyente.CodigoDane ,
               DIRECCIONNOTIFICACIONES =        contribuyente. DireccionNotificaciones ,
              EMAILCOMERCIAL =                  contribuyente.EmailComercial ,
               EMAILNOTIFICACIONES =            contribuyente. EmailNotificaciones ,
               CODIGOACTIVIDADPRINCIPAL =       contribuyente. CodigoActividadPrincipal ,
              CODIGOACTIVIDADSEC1 =             contribuyente.CodigoActividadSec1 ,
              CODIGOACTIVIDADSEC2 =             contribuyente.CodigoActividadSec2 ,
              CODIGOACTIVIDADSEC3=              contribuyente.CodigoActividadSec3,
              FECHAINICIOACTIVIDADES =          contribuyente.FechaInicioActividades ,
              REGIMEN =                         contribuyente.Regimen ,
              NATURALEZAJURIDICA =              contribuyente.NaturalezaJuridica 

                 });
            return resultado>0;
        }

        public async Task<Contribuyente> BuscarContribuyenteporId(string identificacion)
        {

            var result = await Conexion.QueryAsync<Contribuyente>("BUSCAR_CONTRIBUYENTE",
                new
                {
                    NUMEROIDENTIFICACION = identificacion
                });
            return result.FirstOrDefault();
        }



        public async Task<Boolean> ExisteContribuyente(string identificacion)
        {
            var result = await Conexion.ExecuteAsync("BUSCAR_CONTRIBUYENTE",
                 new
                 {
                     NUMEROIDENTIFICACION = identificacion
                 });
              return result > 0;
        }

        public async Task<int> RegistrarContribuyente(Contribuyente contribuyente)
        {
            var result = await Conexion.ExecuteAsync("REGISTRAR_CONTRIBUYENTE",
                new
                {
                    RAZONSOCIAL = contribuyente.RazonSocial,
                    TIPOINSCRIPCION = contribuyente.TipoInscripcion,
                    TIPOPERSONA = contribuyente.TipoPersona,
                    TIPOIDENTIFICACION = contribuyente.TipoIdentificacion,
                    NUMEROIDENTIFICACION = contribuyente.NumeroIdentificacion,
                    DIGITOVERIFICACION = contribuyente.DigitoVerificacion,
                    REPRESENTANTELEGAL = contribuyente.RepresentanteLegal,
                    TIPODOCREPRESENTANTE = contribuyente.TipoDocRepresentante,
                    DOCUMENTOREPRESENTANTE = contribuyente.DocumentoRepresentante,
                    SUPLENTE = contribuyente.Suplente,
                    TIPODOCSUPLENTE = contribuyente.TipoDocSuplente,
                    DOCUMENTOSUPLENTE = contribuyente.DocumentoSuplente,
                    TELEFONOCONTACTO = contribuyente.TelefonoContacto,
                    CODIGODANE = contribuyente.CodigoDane,
                    DIRECCIONNOTIFICACIONES = contribuyente.DireccionNotificaciones,
                    EMAILCOMERCIAL = contribuyente.EmailComercial,
                    EMAILNOTIFICACIONES = contribuyente.EmailNotificaciones,
                    CODIGOACTIVIDADPRINCIPAL = contribuyente.CodigoActividadPrincipal,
                    CODIGOACTIVIDADSEC1 = contribuyente.CodigoActividadSec1,
                    CODIGOACTIVIDADSEC2 = contribuyente.CodigoActividadSec2,
                    CODIGOACTIVIDADSEC3 = contribuyente.CodigoActividadSec3,
                    FECHAINICIOACTIVIDADES = contribuyente.FechaInicioActividades,
                    REGIMEN = contribuyente.Regimen,
                    NATURALEZAJURIDICA = contribuyente.NaturalezaJuridica

                });
            return result;
        }
    }
}
