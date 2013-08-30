using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi.OData.Domain;
using WebApi.OData.Models;

namespace WebApi.OData
{
    public class DomainToModelMappingProfile : Profile
    {
        public DomainToModelMappingProfile()
        {
            Mapper.CreateMap<Movie, MoviePresentationModel>()
                .ForMember(m => m.YearOfRelease, x => x.MapFrom(y => y.Released.Year))
                .ForMember(m => m.AverageRating, x => x.MapFrom(y => y.Ratings.Average(r => r.Rating)))
                .ForMember(m => m.Actors, x => x.MapFrom(y => y.Actors.Select(a => a.Name)));
        }
    }
}