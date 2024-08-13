#region Copyright Syncfusion Inc. 2001 - 2013
// Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Windows;

namespace HorizontalOrientation
{
    public partial class MainWindow : Window
    {
        private Style _dataGridStyle;
        private Style _cellStyle;
        private Style _headerStyle;

        private bool _transposed = false;

        public MainWindow()
        {
            InitializeComponent();
            _dataGridStyle = datagrid.Style;
            _cellStyle = datagrid.CellStyle;
            _headerStyle = datagrid.HeaderStyle;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (_transposed)
            {
                datagrid.Style = _dataGridStyle;
                datagrid.CellStyle = _cellStyle;
                datagrid.HeaderStyle = _headerStyle;
                TransposeButton.Content = "Transpose";
            }
            else
            {
                datagrid.Style = (Style)FindResource("SfDataGridStyle1");
                datagrid.CellStyle = (Style)FindResource("GridCellStyle1");
                datagrid.HeaderStyle = (Style)FindResource("GridHeaderCellControlStyle1");
                TransposeButton.Content = "Normal";
            }

            _transposed = !_transposed;
        }
    }
}

