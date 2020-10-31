using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Prism.Mvvm;
using Prism.Commands;
using System.Windows;
using System.Windows.Input;

namespace JustNode
{
    class ViewModel : BindableBase
    {
        readonly Model _model = new Model();
        public ViewModel()
        {
            _model.PropertyChanged += (o, e) => { RaisePropertyChanged(e.PropertyName); };
            AddNoteCommand = new DelegateCommand(() =>
            {
                WindowAddNote windowAdd = new WindowAddNote(this);
                windowAdd.ShowDialog();
                RaisePropertyChanged("Notes");
              });

            DelNoteCommand = new DelegateCommand<int?>((i) =>
            {
                if (i.HasValue) _model.RemoveNote(i.Value);
            });

        }

        public string Title { set; get; }

        public DelegateCommand AddNoteCommand { get; }
        public DelegateCommand<int?> DelNoteCommand { get; }

        public void DoubleClickCommand(object sender, MouseEventArgs e)
        {
            int i = 
            WindowAddNote windowAdd = new WindowAddNote(this);
            windowAdd.ShowDialog();
            RaisePropertyChanged("Notes");
        }

        public ObservableCollection<Note> Notes => _model.Notes;
    }
}
