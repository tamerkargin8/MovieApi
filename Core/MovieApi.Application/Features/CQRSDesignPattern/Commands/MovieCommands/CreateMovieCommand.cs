using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.CQRSDesignPattern.Commands.MovieCommands
{
    public class CreateMovieCommand
    {
        public string MovieTitle { get; set; }
        public string MovieCoverImageUrl { get; set; }
        public decimal MovieRating { get; set; }
        public string MovieDescription { get; set; }
        public int MovieDuration { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string? MovieCreatedYear { get; set; }
        public bool MovieStatus { get; set; }
    }
}
