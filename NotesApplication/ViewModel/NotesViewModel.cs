using System;
using System.Collections.Generic;
using System.Windows.Input;
using NotesApplication.Model;
using Xamarin.Forms;
using NotesApplication.Views;
using System.Collections.ObjectModel;

namespace NotesApplication.ViewModel
{
    public class NotesViewModel:BaseViewModel
    {
        private ObservableCollection<Notes> _notesLists;
        public ObservableCollection<Notes> NotesLists
        {
            get => _notesLists;
            set 
            {
                SetProperty(ref _notesLists, value); 
            }
        }

        private string _icon;
        public string Icon
        {
            get => _icon;
            set
            {
                SetProperty(ref _icon, value);
              
            }
        }


        private Notes _notesSelected;
        public Notes NotesSelected
        {
            get => _notesSelected;
            set
            {
                SetProperty(ref _notesSelected, value);
                if (_notesSelected != null)
                    ChangeIconProperty();
            }
        }

        private void ChangeIconProperty()
        {
            Icon = "trash.png";
        }

        public ICommand CreateNotesCommand { private set; get; }

        public NotesViewModel(Notes notes)
        {
            Icon = "save.png";
            NotesLists = new NotesList().GetNotes();
            if (notes != null)
                NotesLists.Add(notes); 
            InitializeCommands();
        }

        private void InitializeCommands()
        {
            CreateNotesCommand = new Command(CreateNewNotes);
        }

        private async void CreateNewNotes(object obj)
        {
            if (Icon.Equals("trash.png", StringComparison.CurrentCultureIgnoreCase))
            {
                DeletesNotes();
                Icon = "save.png";
                return;
            }
            Application.Current.MainPage = new NavigationPage(new CreateNotesPage());
        }

        private void DeletesNotes()
        {
            NotesLists.Remove(NotesSelected);
        }
    }
}
