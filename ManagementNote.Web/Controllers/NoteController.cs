using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ManagementNotes.BLL.Service;
using Microsoft.AspNetCore.Mvc;

namespace ManagementNote.Web.Controllers
{
    public class NoteController : Controller
    {
        private readonly INoteService _noteService;
        public NoteController(NoteService noteService)
        {
            _noteService = noteService;
        }

        [HttpGet]
        public IActionResult GetAllNotes()
        {
            return Ok();
        }

        [HttpGet]
        public IActionResult GetNote()
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult CreateNote()
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateNote()
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteNote()
        {
            return Ok();
        }
    }
}
