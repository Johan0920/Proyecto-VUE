using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VUE.API.Models;
using VUE.Aplicacion.CasosUso;

namespace VUE.API.Mappings
{
    public class VueContribuyenteProfile : Profile
    {
        public VueContribuyenteProfile()
        {
            CreateMap<ContribuyenteModel, RegistrarContribuyenteRequest>()
                .ForMember(destino => destino.contribuyente.CodigoActividadPrincipal, action => action.MapFrom(origen => origen.CodigoActividadPrincipal))
                .ForMember(destino => destino.contribuyente.CodigoActividadSec1, action => action.MapFrom(origen => origen.CodigoActividadSec1))
                .ForMember(destino => destino.contribuyente.CodigoActividadSec2, action => action.MapFrom(origen => origen.CodigoActividadSec2))
                .ForMember(destino => destino.contribuyente.CodigoActividadSec3, action => action.MapFrom(origen => origen.CodigoActividadSec3))
                .ForMember(destino => destino.contribuyente.CodigoDane, action => action.MapFrom(origen => origen.CodigoDane))
                .ForMember(destino => destino.contribuyente.DigitoVerificacion, action => action.MapFrom(origen => origen.DigitoVerificacion))
                .ForMember(destino => destino.contribuyente.DireccionNotificaciones, action => action.MapFrom(origen => origen.DireccionNotificaciones))
                .ForMember(destino => destino.contribuyente.DocumentoRepresentante, action => action.MapFrom(origen => origen.DocumentoRepresentante))
                .ForMember(destino => destino.contribuyente.DocumentoSuplente, action => action.MapFrom(origen => origen.DocumentoSuplente))
                .ForMember(destino => destino.contribuyente.EmailComercial, action => action.MapFrom(origen => origen.EmailComercial))
                .ForMember(destino => destino.contribuyente.EmailNotificaciones, action => action.MapFrom(origen => origen.EmailNotificaciones))
                .ForMember(destino => destino.contribuyente.FechaInicioActividades, action => action.MapFrom(origen => origen.FechaInicioActividades))
                .ForMember(destino => destino.contribuyente.NaturalezaJuridica, action => action.MapFrom(origen => origen.NaturalezaJuridica))
                .ForMember(destino => destino.contribuyente.NumeroIdentificacion, action => action.MapFrom(origen => origen.NumeroIdentificacion))
                .ForMember(destino => destino.contribuyente.RazonSocial, action => action.MapFrom(origen => origen.RazonSocial))
                .ForMember(destino => destino.contribuyente.Regimen, action => action.MapFrom(origen => origen.Regimen))
                .ForMember(destino => destino.contribuyente.RepresentanteLegal, action => action.MapFrom(origen => origen.RepresentanteLegal))
                .ForMember(destino => destino.contribuyente.Suplente, action => action.MapFrom(origen => origen.Suplente))
                .ForMember(destino => destino.contribuyente.TelefonoContacto, action => action.MapFrom(origen => origen.TelefonoContacto))
                .ForMember(destino => destino.contribuyente.TipoDocRepresentante, action => action.MapFrom(origen => origen.TipoDocRepresentante))
                .ForMember(destino => destino.contribuyente.TipoDocSuplente, action => action.MapFrom(origen => origen.TipoDocSuplente))
                .ForMember(destino => destino.contribuyente.TipoIdentificacion, action => action.MapFrom(origen => origen.TipoIdentificacion))
                .ForMember(destino => destino.contribuyente.TipoInscripcion, action => action.MapFrom(origen => origen.TipoInscripcion))
                .ForMember(destino => destino.contribuyente.TipoPersona, action => action.MapFrom(origen => origen.TipoPersona));


        }
    }
}
