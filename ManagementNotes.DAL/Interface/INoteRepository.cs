using ManagementNotes.DAL.Entities;
using System.Collections.Generic;

namespace ManagementNotes.DAL.Interface
{
    public interface INoteRepository
    {
        ICollection<Note> GetAllNotes();
        Note GetNote(int id);
        void Create(Note note);
        void Update(int id);
        void Delete(int id);
    }
}
