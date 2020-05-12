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
using Restaurant_library;

// This is Delivery client
namespace Restaurant
{
    public partial class MainWindow : Window
    {
//        private List<DeliveryOrder> _savedOrders;

        public MainWindow() {
            InitializeComponent();
        }

        private void btnNewOrder_OnClick(object sender, RoutedEventArgs e) {
            OrderWindow newOrderWindow = new OrderWindow();
            newOrderWindow.Show( );
        }
        
        private void ChildWindowClosed( object sender, EventArgs e ) {
            MessageBox.Show( ((Window)sender).Name );
        }

    }
}
