using ManagementNotes.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManagementNotes.BLL.Service
{
    public interface INoteService
    {
        ICollection<Note> GetAllNotes();
        Note GetNote(int id);
        void Create(Note note);
        void Update(int id);
        void Delete(int id);
    }
}
