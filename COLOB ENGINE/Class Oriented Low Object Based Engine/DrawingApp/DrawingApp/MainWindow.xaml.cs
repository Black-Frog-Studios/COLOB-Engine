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
using System.IO;

namespace DrawingApp
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

        private void ExitGame(object sender, RoutedEventArgs e)
        {
           Application.Current.Shutdown();
        }

        private void Start_Game(object sender, RoutedEventArgs e)
        {
           // if (File.Exists(""))
           // {
                File.Open("someFile.txt", FileMode.Open);
           // }
        }
    }
}
