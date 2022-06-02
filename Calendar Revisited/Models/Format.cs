using Calendar_Revisited.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace Calendar_Revisited.Models
{
    public class Format : ObservableObject
    {
        private FontStyle _style;
        public FontStyle Style
        {
            get => _style;
            set => OnPropertyChanged(ref _style, value);
        }

        private FontWeight _weight;
        public FontWeight Weight
        {
            get => _weight; 
            set => OnPropertyChanged(ref _weight, value); 
        }

        private FontFamily _family;
        public FontFamily Family
        {
            get => _family; 
            set => OnPropertyChanged(ref _family, value);
        }

        private TextWrapping _wrap;
        public TextWrapping Wrap
        {
            get => _wrap;
            set
            {
                OnPropertyChanged(ref _wrap, value);
                IsWrapped = value == TextWrapping.Wrap ? true : false;
            }
        }

        private bool _isWrapped;
        public bool IsWrapped
        {
            get => _isWrapped;
            set => OnPropertyChanged(ref _isWrapped, value);
        }

        private TextAlignment _alignment;
        public TextAlignment Alignment
        {
            get => _alignment; 
            set => OnPropertyChanged(ref _alignment, value);
        }

        private double _size;
        public double Size
        {
            get => _size;
            set => OnPropertyChanged(ref _size, value);
        }
    }
}
