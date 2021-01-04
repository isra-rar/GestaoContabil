
using GestaoContabil.Data.Context;
using System.Linq;



public class SeedingService
{
    private GestaoContabilContext _context;

    public SeedingService(GestaoContabilContext context)
    {
        _context = context;
    }

    public void Seed()
    {
        if (_context.Receitas.Any() ||
            _context.Despesas.Any())
        {
            return; //DB has been seeded
        }

        _context.SaveChanges();
    }
}
