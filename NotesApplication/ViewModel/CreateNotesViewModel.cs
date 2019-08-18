using System;
using System.Windows.Input;
using Xamarin.Forms;
using NotesApplication.Model;
using NotesApplication.Views;

namespace NotesApplication.ViewModel
{
    public class CreateNotesViewModel : BaseViewModel
    {
        public INavigation _navigation;

        private Notes _note;
        public String Heading
        {
            get => _note.Heading;
            set
            {
                _note.Heading = value;
                OnPropertyChanged();
            }
        }

        public String Task
        {
            get => _note.Task;
            set
            {
                _note.Task = value;
                OnPropertyChanged();
            }
        }

        public DateTime Creation
        {
            get => _note.Created;
            set
            {
                _note.Created = value;
                OnPropertyChanged();
            }
        }

        public ICommand SaveNotesCommand { private set; get; }
        public CreateNotesViewModel(INavigation navigation)
        {
            _navigation = navigation;
            _note = new Notes();
            SaveNotesCommand = new Command(SaveTasks);
        }

        public void SaveTasks()
        {
            var newTask = new Notes { Heading= Heading, Task=Task, Created=DateTime.Now };
            _navigation.PushAsync(new NotesListPage(newTask));

        }
    }
}
