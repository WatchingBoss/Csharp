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

namespace Restorant
{
    public partial class MainWindow : Window
    {
        private List<Order> openOrders = new List<Order>();

        public MainWindow() {
            InitializeComponent();
        }

        private void btnNewOrder_OnClick(object sender, RoutedEventArgs e) {
            openOrders.Add(new Order());
            ++Order.OrderCount;
            openOrders[0].Show( );
        }
    }
}
