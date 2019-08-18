using System;
using System.Collections.Generic;

using Xamarin.Forms;
using NotesApplication.ViewModel;
using NotesApplication.Model;

namespace NotesApplication.Views
{
    public partial class NotesListPage : ContentPage
    {
        Notes _notes;
        public NotesListPage(Notes notes=null)
        {
            InitializeComponent();
            _notes = notes; 
            BindingContext = new NotesViewModel(_notes);
        }
    }
}
