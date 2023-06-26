using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Interfaces.InterfaceServicos;
using Entidades.Entidades;
using InfraEstrutura.Repositorio.Generics;

namespace InfraEstrutura.Repositorio
{
    public class RepositorioSistemaFinanceiro : RepositoryGenerics<SistemaFinanceiro>, InterfaceSistemaFinanceiro
    {
        public Task<IList<SistemaFinanceiro>> ListaSistemaFinanceiro(string emailUsuario)
        {
            throw new NotImplementedException();
        }
    }
}