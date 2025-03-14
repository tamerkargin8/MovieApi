﻿using MovieApi.Application.Features.CQRSDesignPattern.Commands.CategoryCommands;
using MoviesApi.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.CQRSDesignPattern.Handlers.CategoryHandlers
{
    public class RemoveCategoryCommandHandler
    {
        private readonly MovieContext _context;
        public RemoveCategoryCommandHandler(MovieContext context)
        {
            _context = context;
        }
        public async Task Handle(RemoveCategoryCommand command)
        {
            var category = _context.Categories.FirstOrDefault(x => x.CategoryId == command.CategoryId);
            if (category != null)
            {
                _context.Categories.Remove(category);
                await _context.SaveChangesAsync();
            }
        }
    }
}
