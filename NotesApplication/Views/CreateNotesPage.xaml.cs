using System;
using System.Collections.Generic;

using Xamarin.Forms;
using NotesApplication.ViewModel;

namespace NotesApplication.Views
{
    public partial class CreateNotesPage : ContentPage
    {
        public CreateNotesPage()
        {
            InitializeComponent();
            BindingContext = new CreateNotesViewModel(Navigation);
        }
    }
}
