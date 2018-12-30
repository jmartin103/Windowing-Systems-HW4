/* Name: John Martin
   Date: October 20, 2015
   CSc 4380: Windowing Systems Programming
   Homework 4 */

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

namespace JohnMartinHW4
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

        /* This callback is attached to the button under the left combo box to select between the tab control and the
           stack panel */
        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (tabCtrl.IsSelected)
            {
                TabItem tabItem = new TabItem();
                tabItem.Header = "New Tab Item";
                tabControl.Items.Add(tabItem);
            }
            else if (stckPnl.IsSelected)
            {
                Label l = new Label();
                l.Content = "I am a stack panel label.";
                stackPanel.Children.Add(l);
            }
        }

        /* This callback is attached to the button under the right combo box to select between the message box and the 
           file dialog */
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (msgBox.IsSelected)
            {
                MessageBoxResult choice = MessageBox.Show("I am a dialog box.", "", MessageBoxButton.OKCancel);
                Console.WriteLine(choice);
            }
            else if (fileDlg.IsSelected)
            {
                Microsoft.Win32.OpenFileDialog fd = new Microsoft.Win32.OpenFileDialog();
                bool? picked = fd.ShowDialog();

                if (picked == true)
                {
                    Console.WriteLine(fd.SafeFileName);
                }
            }
        }
    }
}
