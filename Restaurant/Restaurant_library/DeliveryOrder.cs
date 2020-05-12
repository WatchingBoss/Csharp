using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant_library
{
    public class DeliveryOrder : IOrder
    {
        private string _firstName, _lastName;
        private int _orderNumber;

        public string FirstName { get => _firstName; set => _firstName = FirstName; }
        public string LastName { get => _lastName; set => _lastName = LastName;  }
        public int OrderNumber { get => _orderNumber; set => _orderNumber = OrderNumber; }
    }

    internal interface IOrder
    {
        string FirstName { get; }
        string LastName { get; }
        int OrderNumber { get; }
    }
}
