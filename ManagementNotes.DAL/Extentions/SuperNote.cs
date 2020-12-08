using ManagementNotes.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManagementNotes.DAL.Extentions
{
    public class SuperNote
    {
        public ICollection<Note> Notes { get; set; }

        public SuperNote()
        {
            Notes = new List<Note>();
        }
    }
}
