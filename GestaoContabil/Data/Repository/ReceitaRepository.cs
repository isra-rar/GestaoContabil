
using GestaoContabil.Data.Context;
using GestaoContabil.Interfaces;
using GestaoContabil.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace GestaoContabil.Data.Repository
{
    public class ReceitaRepository : Repository<Receita>, IReceitaRepository
    {
        public ReceitaRepository(GestaoContabilContext db) : base(db)
        {
        }
    }
}
