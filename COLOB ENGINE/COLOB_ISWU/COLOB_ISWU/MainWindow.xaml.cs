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

namespace COLOB_WPF
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

        private void ISWU_Click(object sender, RoutedEventArgs e)
        {
            if(resultTextBlock.Text == "...")
            {
                resultTextBlock.Text = "ISWU has successfully initialized the necessary systems.";
               // resultTextBlock.FontSize = 24;
            }
            else
            {
                resultTextBlock.Text = "You may now close the program. Systems are working.";
                //resultTextBlock.FontSize = 24;
            }
        }
    }
}
