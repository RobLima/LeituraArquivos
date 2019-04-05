
using AutoMapper;
using ProvaTecnicaWebApplication.Models;
using BLLDomain.Entities;

namespace ProvaTecnicaWebApplication.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        //protected override void Configure()
        //{
        //    Mapper.CreateMap<ClienteViewModel, Cliente>();
        //    Mapper.CreateMap<ProdutoViewModel, Produto>();
        //}
    }
}