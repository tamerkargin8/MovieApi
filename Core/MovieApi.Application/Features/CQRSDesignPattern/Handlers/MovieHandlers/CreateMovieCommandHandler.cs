using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoviesApi.Persistance.Context;
using MovieApi.Domain.Entities;
using MovieApi.Application.Features.CQRSDesignPattern.Commands.MovieCommands;

namespace MovieApi.Application.Features.CQRSDesignPattern.Handlers.MovieHandlers
{
    public class CreateMovieCommandHandler
    {
        private readonly MovieContext _context;
        public CreateMovieCommandHandler(MovieContext context)
        {
            _context = context;
        }
        public async Task Handle(CreateMovieCommand command)
        {
            _context.Movies.Add(new Movie
            {
                MovieCoverImageUrl = command.MovieCoverImageUrl,
                MovieDescription = command.MovieDescription,
                MovieCreatedYear = command.MovieCreatedYear,
                MovieDuration = command.MovieDuration,
                MovieRating = command.MovieRating,
                MovieTitle = command.MovieTitle,
                MovieStatus = command.MovieStatus,
            });
            await _context.SaveChangesAsync();
        }
    }
}
