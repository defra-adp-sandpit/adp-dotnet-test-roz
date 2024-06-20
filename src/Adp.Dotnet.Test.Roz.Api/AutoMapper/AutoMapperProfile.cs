using Adp.Dotnet.Test.Roz.Api.Models;
using Adp.Dotnet.Test.Roz.Core.Entities;

using AutoMapper;

namespace Adp.Dotnet.Test.Roz.Api.AutoMapper;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<ItemRequest, Item>();
    }
}
