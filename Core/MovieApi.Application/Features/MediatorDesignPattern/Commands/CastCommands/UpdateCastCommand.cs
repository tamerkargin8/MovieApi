using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.MediatorDesignPattern.Commands.CastCommands
{
    public class UpdateCastCommand: IRequest
    {
        public int CastId { get; set; }
        public string CastTitle { get; set; }
        public string CastName { get; set; }
        public string CastSurname { get; set; }
        public string CastProfileImageUrl { get; set; }
        public string? CastOverview { get; set; }
        public string? CastBiography { get; set; }
    }
}
