using Calendar_Revisited.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar_Revisited.ViewModels
{
    public class NotepadViewModel
    {
        private Document _document;
        public EditorViewModel Editor { get; set; }
        public FileViewModel File { get; set; }

        public NotepadViewModel()
        {
            _document = new Document();
            Editor = new EditorViewModel(_document);
            File = new FileViewModel(_document);
        }
    }
}
