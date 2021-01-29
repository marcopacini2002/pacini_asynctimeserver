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
using pacini_socketasynclib;

namespace pacini_asynctimeserver
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AsyncSocketServer mserver;
        public MainWindow()
        {
            InitializeComponent();
            mserver = new AsyncSocketServer();
        }

        private void btn_ascolto_Click(object sender, RoutedEventArgs e)
        {
            mserver.InAscolto();
        }

        private void disconnetti_Click(object sender, RoutedEventArgs e)
        {
            mserver.Disconnetti();
        }
    }
}
