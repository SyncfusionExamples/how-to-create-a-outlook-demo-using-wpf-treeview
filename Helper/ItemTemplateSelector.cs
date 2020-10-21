using Syncfusion.UI.Xaml.TreeView.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace NodeWithImageDemo
{
    class ItemTemplateSelector : DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            var treeviewNode = item as TreeViewNode;
            if (treeviewNode == null)
                return null;
            if (treeviewNode.Level == 0)
                return Application.Current.MainWindow.FindResource("headerTemplate") as DataTemplate;
            else
                return Application.Current.MainWindow.FindResource("descriptionTemplate") as DataTemplate;
        }
    }
}
