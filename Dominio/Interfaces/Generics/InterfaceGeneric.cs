using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Interfaces.Generics
{
    public interface InterfaceGeneric<T> where T : class
    {
        Task Add(T objeto);
        Task Update(T objeto);
        Task Delete(T objeto);
        Task<T> GetEntityBYiD(int id);
        Task<List<T>> List();
    }
}