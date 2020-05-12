using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant_library
{
    public class DeliveryOrder
    {
        private string _firstName, _lastName;
        private int _orderNumber;

        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value;  }
        public int OrderNumber { get => _orderNumber; set => _orderNumber = value; }
    }

    internal interface IOrder
    {
        string FirstName { get; set;  }
        string LastName { get; set;  }
        int OrderNumber { get; set;  }
    }
}
