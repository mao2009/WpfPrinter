using WpfPrinter.Interfaces;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace WpfPrinter.Layouts
{

    public class BaseReportLayout : UserControl, IReportLayout
    {
        public ObservableCollection<IReportItemLayoutViewModel> Details { get; set; } = new ObservableCollection<IReportItemLayoutViewModel>();

        public int MaxItemCount => ((IReportLayoutViewModel)this.DataContext).MaxItemCount;
    }
}
