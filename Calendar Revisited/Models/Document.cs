using Calendar_Revisited.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar_Revisited.Models
{
    public class Document : ObservableObject
    {
        private string _text;
        public string Text
        {
            get => _text;
            set => OnPropertyChanged(ref _text, value); 
        }

        private string _filePath;
        public string FilePath
        {
            get => _filePath; 
            set => OnPropertyChanged(ref _filePath, value); 
        }

        private string _fileName;
        public string FileName
        {
            get => _fileName; 
            set => OnPropertyChanged(ref _fileName, value); 
        }

        public bool IsEmpty
        {
            get
            {
                if (string.IsNullOrEmpty(FileName) || string.IsNullOrEmpty(FilePath))
                {
                    return true;
                }
                return false;
            }
        }
    }
}
