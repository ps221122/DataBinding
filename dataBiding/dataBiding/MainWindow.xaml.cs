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

namespace dataBiding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Main _message = new Main();



        public Main myMessage
        {
            get { return _message; }
            set { _message = value; }
        }


        public MainWindow()
        {
            DataContext = myMessage;
            InitializeComponent();
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            
            myMessage.Show();

        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            myMessage.show();
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            myMessage.Styles1();
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            myMessage.Shows();
        }
    }
}


