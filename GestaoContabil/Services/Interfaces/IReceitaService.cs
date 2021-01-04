using GestaoContabil.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace GestaoContabil.Services.Interfaces
{
    public interface IReceitaService : IDisposable
    {
        Task<bool> Add(Receita receita);
        Task<bool> Update(Receita receita);
        Task<bool> Remove(Guid id);

    }
}
