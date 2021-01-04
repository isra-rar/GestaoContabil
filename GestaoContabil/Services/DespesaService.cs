
using GestaoContabil.Interfaces;
using GestaoContabil.Models;
using GestaoContabil.Models.Validations;
using GestaoContabil.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoContabil.Services
{
    public class DespesaService : BaseService, IDespesaService
    {
        private readonly IDespesaRepository _despesaRepository;

        public DespesaService(IDespesaRepository despesaRepository,
            INotifier notification) : base(notification)
        {
            _despesaRepository = despesaRepository;
        }

        public async Task<bool> Add(Despesa despesa)
        {
            if (!ExecuteValidation(new DespesaValidation(), despesa)) return false;

            await _despesaRepository.Add(despesa);
            return true;

        }

        public void Dispose()
        {
            _despesaRepository?.Dispose();
        }

        public async Task<bool> Remove(Guid id)
        {
            var depart = _despesaRepository.GetById(id);
            if (depart == null)
            {
                Notify("Despesa com esse ID não existe");
                return false;
            }

            await _despesaRepository.Remove(id);
            return true;
        }

        public async Task<bool> Update(Despesa despesa)
        {
            if (!ExecuteValidation(new DespesaValidation(), despesa)) return false;

            await _despesaRepository.Update(despesa);
            return true;

        }
    }
}
