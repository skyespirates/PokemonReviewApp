using AutoMapper;
using PokemonReviewApp.Dto;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Helper
{
  class MappingProfiles : Profile
  {
    public MappingProfiles()
    {
      CreateMap<Pokemon, PokemonDto>();
    }
  }  
}