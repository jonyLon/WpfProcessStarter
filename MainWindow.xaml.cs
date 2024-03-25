using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace WpfProcessStarter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string Path;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Open(object sender, RoutedEventArgs e)
        {
            Path = line.Text;
            Process.Start(Path);
        }


        private void Paint(object sender, RoutedEventArgs e)
        {
            Process.Start("mspaint.exe");
        }

        private void Calc(object sender, RoutedEventArgs e)
        {
            Process.Start("calc.exe");
        }

        private void Notepad(object sender, RoutedEventArgs e)
        {
            Process.Start("notepad.exe");
        }
    }
}
