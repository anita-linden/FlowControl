using System;
using System.Collections.Generic;
using System.Text;

namespace FlowControl
{
    public struct Ticket
    {
        private string type;
        private int price;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public int Price
        {
            get { return price; }
            set { price = value; }
        }


    }
}
