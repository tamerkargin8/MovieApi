﻿using MovieApi.Application.Features.CQRSDesignPattern.Commands.CategoryCommands;
using MoviesApi.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.CQRSDesignPattern.Handlers.CategoryHandlers
{
    public class UpdateCategoryCommandHandler
    {
        private readonly MovieContext _context;
        public UpdateCategoryCommandHandler(MovieContext context)
        {
            _context = context;
        }
        public async Task Handle(UpdateCategoryCommand command)
        {
            var category = _context.Categories.FirstOrDefault(x => x.CategoryId == command.CategoryId);
            if (category != null)
            {
                category.CategoryName = command.CategoryName;
                await _context.SaveChangesAsync();
            }
        }
    }
}
