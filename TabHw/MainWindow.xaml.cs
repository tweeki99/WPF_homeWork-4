using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TabHw
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            webBrowser.Items.Insert(webBrowser.Items.IndexOf(addTab), new TabItem
            {
                Header = new TextBlock { Text ="1 вкладка" },
                Content = new WebBrowser { Source = new Uri("https://www.google.ru") },
                IsSelected = true
            });
            //(webBrowser.Items[webBrowser.Items.Count - 2] as TabItem).IsSelected = true;
            webBrowser.SelectionChanged += TabControl_SelectionChanged;
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (addTab.IsSelected /*|| webBrowser.Items.Count == 1*/)
            {
                //(webBrowser.Items[webBrowser.Items.Count - 1] as TabItem).IsSelected = false;

                var tabItem = new TabItem
                {
                    Header = new TextBlock { Text = webBrowser.Items.Count + " вкладка" },
                    Content = new WebBrowser { Source = new Uri("https://www.google.ru") },
                    IsSelected = true
                };


                webBrowser.Items.Insert(webBrowser.Items.IndexOf(addTab), tabItem);
                //(webBrowser.Items[webBrowser.Items.Count - 2] as TabItem).IsSelected = true;
            }
        }
    }
}