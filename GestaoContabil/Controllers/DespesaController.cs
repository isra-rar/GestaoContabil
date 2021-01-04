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
    public class DespesaController : MainController
    {
        private readonly IDespesaRepository _despesaRepository;
        private readonly IDespesaService _despesaService;
        private readonly IMapper _mapper;

        public DespesaController(IDespesaRepository despesaRepository, IMapper mapper
            , IDespesaService despesaService)
        {
            _despesaRepository = despesaRepository;
            _despesaService = despesaService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<DespesaDTO>> GetAllDespesas()
        {
            var despesas = _mapper.Map<IEnumerable<DespesaDTO>>(await _despesaRepository.GetAll());

            return despesas;
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<DespesaDTO>> GetById(Guid id)
        {
            var despesa = _mapper.Map<DespesaDTO>(await _despesaRepository.GetById(id));

            if (despesa == null) return NotFound();

            return despesa;
        }

        [HttpPost]
        public async Task<ActionResult<DespesaDTO>> AddDespesa(DespesaDTO despesaDTO)
        {
            if (!ModelState.IsValid) return BadRequest();

            var despesa = _mapper.Map<Despesa>(despesaDTO);
            var result = await _despesaService.Add(despesa);

            if (!result) return BadRequest();

            return Ok(despesa);
        }

        [HttpPut("{id:guid}")]
        public async Task<ActionResult<DespesaDTO>> UpdateDespesa(Guid id, [FromBody] DespesaDTO despesaDTO)
        {
            if (!ModelState.IsValid) return BadRequest();

            despesaDTO.Id = id;
            var despesa = _mapper.Map<Despesa>(despesaDTO);
            var result = await _despesaService.Update(despesa);

            if (!result) return BadRequest();

            return Ok(despesa);
        }

        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<DespesaDTO>> DeleteDespesa(Guid id)
        {
            var despesa = _mapper.Map<DespesaDTO>(await _despesaRepository.GetById(id));

            if (despesa == null) return NotFound();

            var result = await _despesaService.Remove(id);

            if (!result) return BadRequest();

            return NoContent();
        }
    }
}
