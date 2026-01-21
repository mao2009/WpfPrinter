using System.Collections.ObjectModel;

namespace WpfPrinter.Interfaces
{
    public interface IReportLayoutViewModel
    {
        double Width { get; set; }

        double Height { get; set; }


        int MaxItemCount { get; set; }

        ObservableCollection<IReportItemLayoutViewModel> Details { get; set; }

    }
}
