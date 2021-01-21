using System;
using System.Collections.Generic;
using System.Text;

namespace FlowControl
{
    /// <summary>
    /// Det stod inget om att jag inte fick ha en extra klass. :)
    /// En enkel datatyp för att hantera en sträng och en integer tillsammans för biljettpris texten.
    /// </summary>
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
