using MediatR;
using MovieApi.Application.Features.MediatorDesignPattern.Commands.CastCommands;
using MovieApi.Domain.Entities;
using MoviesApi.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.MediatorDesignPattern.Handlers.CastHandlers
{
    public class CreateCastCommandHandler : IRequestHandler<CreateCastCommand>
    {
        private readonly MovieContext _context;

        public CreateCastCommandHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task Handle(CreateCastCommand request, CancellationToken cancellationToken)
        {
            await _context.Casts.AddAsync(new Cast
            {
                CastTitle = request.CastTitle,
                CastName = request.CastName,
                CastSurname = request.CastSurname,
                CastProfileImageUrl = request.CastProfileImageUrl,
                CastOverview = request.CastOverview,
                CastBiography = request.CastBiography
            });
            await _context.SaveChangesAsync();
        }
    }
}
