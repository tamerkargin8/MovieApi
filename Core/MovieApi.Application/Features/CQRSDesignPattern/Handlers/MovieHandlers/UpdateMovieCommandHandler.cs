using MovieApi.Application.Features.CQRSDesignPattern.Commands.MovieCommands;
using MoviesApi.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.CQRSDesignPattern.Handlers.MovieHandlers
{
    public class UpdateMovieCommandHandler
    {
        private readonly MovieContext _context;
        public UpdateMovieCommandHandler(MovieContext context)
        {
            _context = context;
        }
        public async Task Handle(UpdateMovieCommand command)
        {
            var movie = _context.Movies.FirstOrDefault(x => x.MovieId == command.MovieId);
            if (movie != null)
            {
                movie.MovieTitle = command.MovieTitle;
                movie.MovieDescription = command.MovieDescription;
                movie.MovieDuration = command.MovieDuration;
                movie.MovieRating = command.MovieRating;
                movie.MovieCoverImageUrl = command.MovieCoverImageUrl;
                movie.MovieCreatedYear = command.MovieCreatedYear;
                movie.MovieStatus = command.MovieStatus;
                await _context.SaveChangesAsync();
            }
        }
    }
}
