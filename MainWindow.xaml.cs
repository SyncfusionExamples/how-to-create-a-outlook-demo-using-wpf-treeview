using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Data;

namespace NodeWithImageDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SfTreeView_QueryNodeSize(object sender, Syncfusion.UI.Xaml.TreeView.QueryNodeSizeEventArgs e)
        {
            if (e.Node.Level == 0)
                e.Height = 25;
            else
                e.Height = 40;
            e.Handled = true;
        }
    }
}
