using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Interfaces.Generics;
using Entidades.Entidades;

namespace Dominio.Interfaces.InterfaceServicos
{
    public interface IDespesaServico 
    {
    Task<IList<Despesa>> ListarDespesasUsuario (Despesa despesa);

    Task<IList<Despesa>> ListarDespesasUsuarioNaoPagasMesesAnterior (Despesa despesa);
    }
}