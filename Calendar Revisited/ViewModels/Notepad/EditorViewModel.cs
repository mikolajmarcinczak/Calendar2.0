using Calendar_Revisited.Models;
using Calendar_Revisited.Utilities;
using System.Windows.Input;

namespace Calendar_Revisited.ViewModels
{
    public class EditorViewModel
    {
        public ICommand FormatCommand { get; }
        public ICommand WrapCommand { get; }
        public ICommand AlignCommand { get; }
        public Document Document { get; set; }
        public Format Format { get; set; }

        public EditorViewModel(Document document)
        {
            Document = document;
            Format = new Format();
            FormatCommand = new RelayCommand(OpenStyleDialog);
            WrapCommand = new RelayCommand(ToggleWrap);
            AlignCommand = new RelayCommand(ToggleAlignment);
        }

        private void OpenStyleDialog()
        {
            var fontDialog = new Views.FontDialog();
            fontDialog.DataContext = Format;
            fontDialog.ShowDialog();
        }

        private void ToggleWrap()
        {
            if (Format.Wrap == System.Windows.TextWrapping.Wrap)
            {
                Format.Wrap = System.Windows.TextWrapping.NoWrap;
            }
            else
            {
                Format.Wrap = System.Windows.TextWrapping.Wrap;
            }
        }

        private void ToggleAlignment()
        {
            if (Format.Alignment == System.Windows.TextAlignment.Left)
            {
                Format.Alignment = System.Windows.TextAlignment.Center;
            }
            else if (Format.Alignment == System.Windows.TextAlignment.Center)
            {
                Format.Alignment = System.Windows.TextAlignment.Right;
            }
            else if (Format.Alignment == System.Windows.TextAlignment.Right)
            {
                Format.Alignment= System.Windows.TextAlignment.Justify;
            }
            else
            {
                Format.Alignment = System.Windows.TextAlignment.Left;
            }
        }
    }
}
