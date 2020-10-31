using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Prism.Mvvm;
using Prism.Commands;

namespace JustNode
{
    class Model : BindableBase
    {
        public ObservableCollection<Note> Notes;
        public Model()
        {
            Notes = new ObservableCollection<Note>
            {
                new Note("1", "123")
            };

        }

        public void AddNote(string title, string description)
        {
            Notes.Add(new Note(title, description));
        }
        public void RemoveNote(int index)
        {
            Notes.RemoveAt(index);
        }
        public void SelectedNote(int i, ref string title, ref string description)
        {
            title = Notes[i].Title;
            description = Notes[i].Description;
        }
    }
}
