using System.Windows;

namespace Restorant
{
    public partial class Order : Window, IOrder
    {
        public static int OrderCount { get; set; }

        private string _firstName, _lastName;
        private int _orderNumber;

        public string FirstName { get => _firstName; }
        public string LastName { get => _lastName; }
        public int OrderNumber { get => _orderNumber; }

        public Order( ) {
            InitializeComponent( );

            _orderNumber = OrderCount;
        }

        private void tboxFirstName_OnLostForus( object sender, RoutedEventArgs e ) {
            _firstName = tboxFirstName.Text;
        }

        private void tboxLastName_OnLostForus( object sender, RoutedEventArgs e ) {
            _lastName = tboxLastName.Text;
        }

        private void btnCheckPersonInfo_OnClick( object sender, RoutedEventArgs e ) {
            MessageBox.Show( $"First name: {FirstName}\n" +
                $"Last name: {LastName}" );
        }
    }

    internal interface IOrder
    {
        string FirstName { get; }
        string LastName { get; }
        int OrderNumber { get; }
    }
}