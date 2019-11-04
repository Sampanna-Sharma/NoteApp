using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NoteApp.Core.Entities;
using NoteApp.Core.Services;

namespace AspNetCoreTodo.Controllers
{
    public class NoteController : Controller
    {
        private readonly INotesService _notesService;

        public NoteController(INotesService notesService)
        {
            _notesService = notesService;

        }
        public async Task<IActionResult> IndexAsync(){
        var items = await _notesService.GetIncompleteItemsAsync();
            var model = new NoteViewModel()
            {
                Notes = items

            };
        return View(model);
        }
    }
}