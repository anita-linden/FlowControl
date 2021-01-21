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
        public Ticket(string type, int price)
        {
            Type = type;
            Price = price;
        }

        public string Type { get; }

        public int Price { get; }


    }
}
