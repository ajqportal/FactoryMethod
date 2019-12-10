using System;
using System.Collections.Generic;
using System.Text;
using Design.Pattern.Factory.Method.Interface;
using Design.Pattern.Factory.Method.Models;

namespace Design.Pattern.Factory.Method.Business
{
    public class SeaLogistics : ILogistics
    {
        public ITransport CreateTransport()
        {
            Console.WriteLine("Created and selected a Sea Logistics.");
            return new Ship();
        }
    }
}
