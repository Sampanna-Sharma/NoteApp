using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NoteApp.Core.Entities;

namespace NoteApp.Infrastructure.Services
{
    public class FakeNotesService : INotesService
    {
        public Task<Note[]> GetIncompleteItemsAsync()
        {
            var item1 = new Note
            {
                Title = "Learn ASP.NET Core",
                TimeToComplete = DateTimeOffset.Now.AddDays(1)
            };

            var item2 = new Note
            {
                Title = "Build awesome apps",
                TimeToComplete = DateTimeOffset.Now.AddDays(2)
            };

            return Task.FromResult(new[] { item1, item2 });
        }
    }
}
