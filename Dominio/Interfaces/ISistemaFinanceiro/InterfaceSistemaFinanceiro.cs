using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entidades.Entidades;

namespace Dominio.Interfaces.InterfaceServicos
{
    public interface InterfaceSistemaFinanceiro
    {
        Task<IList<SistemaFinanceiro>> ListaSistemaFinanceiro (string emailUsuario);
    }
}