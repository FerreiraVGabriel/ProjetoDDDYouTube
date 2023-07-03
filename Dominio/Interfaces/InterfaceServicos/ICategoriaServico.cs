using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Interfaces.Generics;
using Entidades.Entidades;

namespace Dominio.Interfaces.InterfaceServicos
{
    public interface ICategoriaServico
    {
        Task AdicionarCategoria(Categoria catagoria);
        Task AtualizarCategoria(Categoria catagoria);
    }
}