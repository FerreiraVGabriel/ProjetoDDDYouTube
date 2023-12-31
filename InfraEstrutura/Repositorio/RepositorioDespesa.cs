using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Interfaces.IDespesa;
using Entidades.Entidades;
using InfraEstrutura.Configuracao;
using InfraEstrutura.Repositorio.Generics;
using Microsoft.EntityFrameworkCore;

namespace InfraEstrutura.Repositorio
{
    public class RepositorioDespesa : RepositoryGenerics<Despesa>, InterfaceDespesa
    {
        private readonly DbContextOptions<ContextBase> _OptionsBuilder;

        public RepositorioDespesa()
        {
            _OptionsBuilder = new DbContextOptions<ContextBase>();
        }
        public async Task<IList<Despesa>> ListarDespesasUsuario(string emailUsuario)
        {
            using (var banco = new ContextBase(_OptionsBuilder))
            {
                return await
                   (from s in banco.SistemaFinanceiro
                    join c in banco.Categoria on s.Id equals c.IdSistema
                    join us in banco.UsuarioSistemaFinanceiro on s.Id equals us.IdSistema
                    join d in banco.Despesa on c.Id equals d.IdCategoria
                    where us.EmailUsuario.Equals(emailUsuario) && s.Mes == d.Mes && s.Ano == d.Ano
                    select d).AsNoTracking().ToListAsync();
            }
        }

        public async Task<IList<Despesa>> ListarDespesasUsuarioNaoPagasMesesAnterior(string emailUsuario)
        {
            using (var banco = new ContextBase(_OptionsBuilder))
            {
                return await
                   (from s in banco.SistemaFinanceiro
                    join c in banco.Categoria on s.Id equals c.IdSistema
                    join us in banco.UsuarioSistemaFinanceiro on s.Id equals us.IdSistema
                    join d in banco.Despesa on c.Id equals d.IdCategoria
                    where us.EmailUsuario.Equals(emailUsuario) && d.Mes < DateTime.Now.Month && !d.Pago
                    select d).AsNoTracking().ToListAsync();
            }
        }
    }
}