using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Interfaces.Generics;
using Entidades.Entidades;

namespace Dominio.Interfaces.IUsuarioSistemaFinanceiro
{
    public interface InterfaceUsuarioSistemaFinanceiro: InterfaceGeneric<UsuarioSistemaFinanceiro>
    {
        Task<IList<UsuarioSistemaFinanceiro>> ListarUsuariosSistema (int IdSistema);
        Task RemoveUsuarios (List<UsuarioSistemaFinanceiro> usuarios);
        Task <UsuarioSistemaFinanceiro> ObterUsuarioPorEmail (string emailUsuario);
    }
}