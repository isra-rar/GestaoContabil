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
    public class ReceitaService : BaseService, IReceitaService
    {

        private readonly IReceitaRepository _receitaRepository;

        public ReceitaService(IReceitaRepository receitaRepository,
            INotifier notification) : base(notification)
        {
            _receitaRepository = receitaRepository;
        }


        public async Task<bool> Add(Receita receita)
        {
            if (!ExecuteValidation(new ReceitaValidation(), receita)) return false;

            await _receitaRepository.Add(receita);
            return true;
        }

        public async Task<bool> Update(Receita receita)
        {
            if (!ExecuteValidation(new ReceitaValidation(), receita)) return false;

            await _receitaRepository.Update(receita);
            return true;
        }

        public async Task<bool> Remove(Guid id)
        {
            var receita = _receitaRepository.GetById(id);
            if (receita == null)
            {
                Notify("Receita com esse ID não existe");
                return false;
            }

            await _receitaRepository.Remove(id);
            return true;
        }
        public void Dispose()
        {
            _receitaRepository?.Dispose();
        }
    }
}
