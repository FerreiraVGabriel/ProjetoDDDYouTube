using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Interfaces.ICategoria;
using Dominio.Interfaces.InterfaceServicos;
using Entidades.Entidades;

namespace Dominio.Servicos
{
    public class CategoriaServico : ICategoriaServico
    {
      private readonly InterfaceCategoria _interfaceCategoria;
        public CategoriaServico(InterfaceCategoria interfaceCategoria)
        {
            _interfaceCategoria = interfaceCategoria;
        }

        public async Task AdicionarCategoria(Categoria categoria)
        {
            var valido = categoria.ValidarPropriedadeString(categoria.Nome, "Nome");
            if (valido)
                await _interfaceCategoria.Add(categoria);
        }

        public async Task AtualizarCategoria(Categoria categoria)
        {
            var valido = categoria.ValidarPropriedadeString(categoria.Nome, "Nome");
            if (valido)
                await _interfaceCategoria.Update(categoria);
        }
    }
}