using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Interfaces.Generics;
using Entidades.Entidades;

namespace Dominio.Interfaces.IDespesa
{
    public interface InterfaceDespesa: InterfaceGeneric<Despesa>
    {
         Task<IList<Despesa>> ListarDespesasUsuario (string emailUsuario);

         Task<IList<Despesa>> ListarDespesasUsuarioNaoPagasMesesAnterior (string emailUsuario);
    }
}