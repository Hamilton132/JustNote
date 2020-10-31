using System;
using System.Collections.Generic;
using System.Text;

namespace JustNode
{
    class Note
    {
        public string Title { set; get; }
        public string Description { set; get; }
        public Note(string title, string description)
        {
            Title = title;
            Description = description;
        }
    }
}
