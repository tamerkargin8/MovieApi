using Microsoft.Identity.Client;
using MovieApi.Application.Features.CQRSDesignPattern.Queries.MovieQueries;
using MovieApi.Application.Features.CQRSDesignPattern.Results.MovieResults;
using MoviesApi.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.CQRSDesignPattern.Handlers.MovieHandlers
{
    public class GetMovieByIdQueryHandler
    {
        private readonly MovieContext _context;
        public GetMovieByIdQueryHandler(MovieContext context)
        {
            _context = context;
        }
        public async Task<GetMovieByIdResult> Handle(GetMovieByIdQuery query)
        {
            var value = await _context.Movies.FindAsync(query.MovieId);
            return new GetMovieByIdResult
            {
                MovieId = value.MovieId,
                MovieTitle = value.MovieTitle,
                MovieCoverImageUrl = value.MovieCoverImageUrl,
                MovieRating = value.MovieRating,
                MovieDescription = value.MovieDescription,
                MovieDuration = value.MovieDuration,
                ReleaseDate = value.ReleaseDate,
                MovieCreatedYear = value.MovieCreatedYear,
                MovieStatus = value.MovieStatus
            };
        }
    }
}
