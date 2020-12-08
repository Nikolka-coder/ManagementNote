using ManagementNotes.DAL.Entities;
using ManagementNotes.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManagementNotes.BLL.Service
{
    public class NoteService : INoteService
    {

        private readonly INoteRepository _noteRepository;

        public NoteService(INoteRepository noteRepository)
        {
            _noteRepository = noteRepository;
        }
        public void Create(Note note)
        {
            _noteRepository.Create(note);
        }

        public void Delete(int id)
        {
            _noteRepository.Delete(id);
        }

        public ICollection<Note> GetAllNotes()
        {
            return _noteRepository.GetAllNotes();
        }

        public Note GetNote(int id)
        {
            return _noteRepository.GetNote(id);
        }

        public void Update(int id)
        {
            _noteRepository.Update(id);
        }
    }
}
