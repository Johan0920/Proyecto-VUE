using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VUE.Dominio.Modelos;

namespace VUE.Dominio.Repositorios
{
    public interface IContribuyenteRepositorio
    {
        Task<int> RegistrarContribuyente(Contribuyente contribuyente);
        Task<Boolean> ExisteContribuyente(String identificacion);
        Task<Boolean> ActualizarContribuyente(Contribuyente contribuyente);
        Task<Contribuyente> BuscarContribuyenteporId(String identificacion);

    }
}
