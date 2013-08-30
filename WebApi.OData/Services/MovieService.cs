using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi.OData.Domain;
using WebApi.OData.Models;
using WebApi.OData.Repositories;
using System.Web.Http;
using AutoMapper.QueryableExtensions;

namespace WebApi.OData.Services
{
    public class MovieService
    {
        private readonly MovieRepository movieRepository;

        public MovieService(MovieRepository movieRepository)
        {
            this.movieRepository = movieRepository;
        }

        public IQueryable<MoviePresentationModel> Get()
        {
            return movieRepository.GetAll().Project<Movie>().To<MoviePresentationModel>();
        }
    }
}