using AutoMapper;
using GestaoContabil.DTO;
using GestaoContabil.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoContabil.Configuration
{
    public class AutomapperConfig : Profile
    {
        public AutomapperConfig()
        {
            CreateMap<Receita, ReceitaDTO>().ReverseMap();
            CreateMap<Despesa, DespesaDTO>().ReverseMap();        
        } 
    }
}
