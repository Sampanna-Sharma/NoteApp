using NoteApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp.Infrastructure.Services
{
    public interface INotesService
    {
      Task<Note[]> GetIncompleteItemsAsync();

    }
}
