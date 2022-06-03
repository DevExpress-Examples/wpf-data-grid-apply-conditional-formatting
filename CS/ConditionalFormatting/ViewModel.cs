using System.Collections.ObjectModel;

namespace ConditionalFormatting {
    public class ViewModel {
        public ViewModel() {
            Items = SaleDataModel.GetSales();
        }
        public ObservableCollection<SaleData> Items { get; set; }
    }
}
