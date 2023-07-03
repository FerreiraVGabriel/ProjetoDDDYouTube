using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Interfaces.InterfaceServicos;
using Dominio.Interfaces.IUsuarioSistemaFinanceiro;
using Entidades.Entidades;

namespace Dominio.Servicos
{
      public class UsuarioSistemaFinanceiroServico : IUsuarioSistemaFinanceiroServico
    {

        private readonly InterfaceUsuarioSistemaFinanceiro _interfaceUsuarioSistemaFinanceiro;

        public UsuarioSistemaFinanceiroServico(InterfaceUsuarioSistemaFinanceiro interfaceUsuarioSistemaFinanceiro)
        {
            _interfaceUsuarioSistemaFinanceiro = interfaceUsuarioSistemaFinanceiro;
        }

        public async Task CadastrarUsuarioNoSistema(UsuarioSistemaFinanceiro usuarioSistemaFinanceiro)
        {
            await _interfaceUsuarioSistemaFinanceiro.Add(usuarioSistemaFinanceiro);
        }
    }
}