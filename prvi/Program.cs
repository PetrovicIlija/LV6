using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace prvi
{
    class Program
    {
        static void Main(string[] args)
        {
            var myNotes = new List<Note>() {
                new Note("prva biljeska", "korona"),
                new Note("druga biljeska", "karantena"),
            };
            Notebook myNotebook = new Notebook(myNotes);
            Note myNewNote = new Note("treca biljeska", "samoizolacija");
            myNotebook.AddNote(myNewNote);
            IAbstractIterator iterator = myNotebook.GetIterator();
            Note toPrint;
            for(toPrint=iterator.First(); iterator.IsDone == false; toPrint=iterator.Next())
            {
                toPrint.Show();
            }
        }
    }
}
