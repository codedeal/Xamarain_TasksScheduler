using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
namespace NotesApplication.Model
{
    public class NotesList
    {
       public ObservableCollection<Notes> GetNotes()
        {
            var notesList = new ObservableCollection<Notes>()
            {
                new Notes{ Heading="Grocery",Task="Bring fresh Veegies and Fruits",Created=DateTime.Now},
                 new Notes{ Heading="Laundary",Task="Wash and Iron jeans and sweatshirts",Created=DateTime.Now},
                  new Notes{ Heading="Study",Task="Read Chapter 4 Verse 67 of RunnerKite",Created=DateTime.Now}

            };
            return notesList;
        }
    }
}
