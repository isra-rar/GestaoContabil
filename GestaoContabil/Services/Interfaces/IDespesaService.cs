
using GestaoContabil.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoContabil.Services.Interfaces
{
    public interface IDespesaService : IDisposable
    {
        Task<bool> Add(Despesa despesa);
        Task<bool> Update(Despesa despesa);
        Task<bool> Remove(Guid id);
    }
}
