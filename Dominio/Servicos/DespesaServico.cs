using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Interfaces.IDespesa;
using Dominio.Interfaces.InterfaceServicos;
using Entidades.Entidades;

namespace Dominio.Servicos
{
    public class DespesaServico : IDespesaServico
    {
         private readonly InterfaceDespesa _InterfaceDespesa;
        public DespesaServico(InterfaceDespesa InterfaceDespesa)
        {
            _InterfaceDespesa = InterfaceDespesa;
        }

        public async Task AdicionarDespesa(Despesa despesa)
        {
            var data = DateTime.UtcNow;
            despesa.DataCadastro = data;
            despesa.Ano = data.Year;
            despesa.Mes = data.Month;

            var valido = despesa.ValidarPropriedadeString(despesa.Nome, "Nome");
            if (valido)
                await _InterfaceDespesa.Add(despesa);

        }

        public async Task AtualizarDespesa(Despesa despesa)
        {
            var data = DateTime.UtcNow;
            despesa.DataAlteracao = data;

            if (despesa.Pago)
            {
                despesa.DataPagamento = data;
            }

            var valido = despesa.ValidarPropriedadeString(despesa.Nome, "Nome");
            if (valido)
                await _InterfaceDespesa.Update(despesa);
        }

        public Task<IList<Despesa>> ListarDespesasUsuario(Despesa despesa)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Despesa>> ListarDespesasUsuarioNaoPagasMesesAnterior(Despesa despesa)
        {
            throw new NotImplementedException();
        }
    }
}