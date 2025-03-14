﻿using MovieApi.Application.Features.CQRSDesignPattern.Commands.MovieCommands;
using MoviesApi.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.CQRSDesignPattern.Handlers.MovieHandlers
{
    public class RemoveMovieCommandHandler
    {
        private readonly MovieContext _context;
        public RemoveMovieCommandHandler(MovieContext context)
        {
            _context = context;
        }
        public async Task Handle(RemoveMovieCommand command)
        {
            var movie = _context.Movies.FirstOrDefault(x => x.MovieId == command.MovieId);
            if (movie != null)
            {
                _context.Movies.Remove(movie);
                await _context.SaveChangesAsync();
            }
        }
    }
}
