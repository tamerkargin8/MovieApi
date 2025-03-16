using MediatR;
using MovieApi.Application.Features.MediatorDesignPattern.Commands.CastCommands;
using MoviesApi.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.MediatorDesignPattern.Handlers.CastHandlers
{
    public class UpdateCastCommandHandler : IRequestHandler<UpdateCastCommand>
    {
        private readonly MovieContext _context;
        public UpdateCastCommandHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task Handle(UpdateCastCommand request, CancellationToken cancellationToken)
        {
            var values = await _context.Casts.FindAsync(request.CastId);
            values.CastTitle = request.CastTitle;
            values.CastName = request.CastName;
            values.CastSurname = request.CastSurname;
            values.CastProfileImageUrl = request.CastProfileImageUrl;
            values.CastOverview = request.CastOverview;
            values.CastBiography = request.CastBiography;
            await _context.SaveChangesAsync();
        }
    }
}
