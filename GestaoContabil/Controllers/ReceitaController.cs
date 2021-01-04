using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using GestaoContabil.DTO;
using GestaoContabil.Interfaces;
using GestaoContabil.Models;
using GestaoContabil.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GestaoContabil.Controllers
{
    [Route("api/[controller]")]
    public class ReceitaController : MainController
    {
        private readonly IReceitaRepository _receitaRepository;
        private readonly IReceitaService _receitaService;
        private readonly IMapper _mapper;

        public ReceitaController(IReceitaRepository receitaRepository, IMapper mapper
            ,IReceitaService receitaservice)
        {
            _receitaRepository = receitaRepository;
            _receitaService = receitaservice;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<ReceitaDTO>> GetAllReceitas()
        {
            var receitas = _mapper.Map<IEnumerable<ReceitaDTO>>(await _receitaRepository.GetAll());

            return receitas;
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<ReceitaDTO>> GetById(Guid id)
        {
            var receita = _mapper.Map<ReceitaDTO>(await _receitaRepository.GetById(id));

            if (receita == null) return NotFound();

            return receita;
        }

        [HttpPost]
        public async Task<ActionResult<ReceitaDTO>> AddReceita([FromBody] ReceitaDTO receitaDTO)
        {
            if (!ModelState.IsValid) return BadRequest();

            var receita = _mapper.Map<Receita>(receitaDTO);
            var result = await _receitaService.Add(receita);

            if (!result) return BadRequest();

            return Ok(receita);
        }

        [HttpPut("{id:guid}")]
        public async Task<ActionResult<ReceitaDTO>> UpdateReceita(Guid id, [FromBody] ReceitaDTO receitaDTO)
        {
            if (!ModelState.IsValid) return BadRequest();

            receitaDTO.Id = id;
            var receita = _mapper.Map<Receita>(receitaDTO);
            var result = await _receitaService.Update(receita);

            if (!result) return BadRequest();

            return Ok(receita);
        }

        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<ReceitaDTO>> DeleteReceita(Guid id)
        {
            var receita = _mapper.Map<ReceitaDTO>(await _receitaRepository.GetById(id));

            if (receita == null) return NotFound();

            var result = await _receitaService.Remove(id);

            if (!result) return BadRequest();

            return NoContent();
        }
    }
}
