using System.Collections.ObjectModel;
using System.Windows;

namespace WpfPrinter.Interfaces
{
    public interface IReportLayout
    {
        int MaxItemCount { get; }

        double Width { get; set; }

        double Height { get; set; }

        void Measure(Size availableSize);

        void Arrange(Rect finalRect);
        void UpdateLayout();

        ObservableCollection<IReportItemLayoutViewModel> Details { get; set; }
    }
}
