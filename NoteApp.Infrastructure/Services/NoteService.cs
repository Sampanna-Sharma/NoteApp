using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NoteApp.Core.Entities;
using NoteApp.Infrastructure.EF;

namespace NoteApp.Infrastructure.Services
{
    public class NoteService : INotesService
    {
        private readonly ApplicationDbContext applicationDbContext;
        public NoteService(ApplicationDbContext _applicationDbContext)
        {
            applicationDbContext = _applicationDbContext;

        }
        public async Task<Note[]> GetIncompleteItemsAsync()
        {
            var items = await applicationDbContext.Notes
                .Where(x => x.IsCompleted == false)
                .ToArrayAsync();
            return items;
        }
    }
}
