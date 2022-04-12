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

        public NotepadViewModel()
        {
            _document = new Document();
        }
    }
}
