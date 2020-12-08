using ManagementNotes.DAL.Entities;
using ManagementNotes.DAL.Extentions;
using ManagementNotes.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ManagementNotes.DAL.Repository
{
    public class NoteRepository : INoteRepository
    {
        private readonly SuperNote _superNote;

        public NoteRepository(SuperNote superNote)
        {
            _superNote = superNote;
        }

        public void Create(Note note)
        {
            _superNote.Notes.Add(note);
        }

        public void Delete(int id)
        {
            Note note = _superNote.Notes.FirstOrDefault(n => n.Id == id);
            if (note != null)
                _superNote.Notes.Remove(note);
        }

        public ICollection<Note> GetAllNotes()
        {
            return _superNote.Notes;
        }

        public Note GetNote(int id)
        {
            return _superNote.Notes.FirstOrDefault(n => n.Id == id);
        }

        public void Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
