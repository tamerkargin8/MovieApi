using Microsoft.EntityFrameworkCore;
using MovieApi.Application.Features.CQRSDesignPattern.Results.MovieResults;
using MoviesApi.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.CQRSDesignPattern.Handlers.MovieHandlers
{
    public class GetMovieQueryHandler
    {
        private readonly MovieContext _context;
        public GetMovieQueryHandler(MovieContext context)
        {
            _context = context;
        }
        public async Task<List<GetMovieQueryResult>> Handle()
        {
            var values = await _context.Movies.ToListAsync();
            return values.Select(values => new GetMovieQueryResult
            {
                MovieId = values.MovieId,
                MovieTitle = values.MovieTitle,
                MovieDescription = values.MovieDescription,
                MovieDuration = values.MovieDuration,
                MovieRating = values.MovieRating,
                MovieCoverImageUrl = values.MovieCoverImageUrl,
                MovieCreatedYear = values.MovieCreatedYear,
                MovieStatus = values.MovieStatus
            }).ToList();
        }
    }
}
