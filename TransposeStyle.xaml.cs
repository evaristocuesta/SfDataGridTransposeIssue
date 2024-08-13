using Syncfusion.UI.Xaml.Grid;
using System.Windows;

namespace HorizontalOrientation
{
    partial class TransposeStyle : ResourceDictionary
    {
        private void PART_VisualContainer_Loaded(object sender, RoutedEventArgs e)
        {
            var visualcontainer = sender as VisualContainer;
            visualcontainer.RowHeights.DefaultLineSize = 120;
            visualcontainer.RowHeights[0] = 120;
            visualcontainer.ColumnWidths.DefaultLineSize = 30;
        }
    }
}
