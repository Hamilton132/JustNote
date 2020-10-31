using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace JustNode
{
    /// <summary>
    /// Логика взаимодействия для WindowAddNote.xaml
    /// </summary>
    public partial class WindowAddNote : Window
    {
        private readonly ViewModel _mainVM;
        public WindowAddNote(Object mainVM)
        {
            InitializeComponent();
            _mainVM = (ViewModel)mainVM;
        }
        public string Description { set; get; }
        public string Title { set; get; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Description = new TextRange(description.Document.ContentStart, description.Document.ContentEnd).Text;
            Title = title.Text;
            if (Title != "")
            {
                _mainVM.Notes.Add(new Note(Title, Description));
                this.Close();
            }
        }
    }
}
