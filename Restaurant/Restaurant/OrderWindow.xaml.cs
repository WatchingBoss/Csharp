﻿using System.Linq;
using System.Windows;
using System.Windows.Navigation;
using Restaurant_library;

namespace Restaurant
{
    public partial class OrderWindow : Window {
        private DeliveryOrder _order;
        private int _saveOrderCount;

        public DeliveryOrder NewOrder { get => _order; }

        public OrderWindow( ) {
            InitializeComponent( );
            _order = new DeliveryOrder( );
            _saveOrderCount = 0;
        }

        private void tboxFirstName_OnLostForus( object sender, RoutedEventArgs e ) {
            _order.FirstName = tboxFirstName.Text;
        }

        private void tboxLastName_OnLostForus( object sender, RoutedEventArgs e ) {
            _order.LastName = tboxLastName.Text;
        }

        private void btnCheckPersonInfo_OnClick( object sender, RoutedEventArgs e ) {
            MessageBox.Show( $"First name: {_order.FirstName}\n" +
                $"Last name: {_order.LastName}" );
        }

        private void btnSaveOrder_OnClick( object sender, RoutedEventArgs e ) {
            ++_saveOrderCount;
        }
    }

}