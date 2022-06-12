using AutoMapper;
using SistemaNotas.DTOs;
using SistemaNotas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaNotas.Mapping
{
    public class SefazMapping : Profile
    {
        public SefazMapping()
        {
            CreateMap<Sefaz, SefazDTO>()
             .ForMember(dest => dest.Nome,
             map => map.MapFrom(src => $" { src.Nome } { src.Logradouro }"))
                .ReverseMap();
        }
    }
}
