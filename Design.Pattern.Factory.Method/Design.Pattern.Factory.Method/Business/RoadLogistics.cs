using System;
using System.Collections.Generic;
using System.Text;
using Design.Pattern.Factory.Method.Interface;
using Design.Pattern.Factory.Method.Models;

namespace Design.Pattern.Factory.Method.Business
{
    public class RoadLogistics: ILogistics
    {
        public ITransport CreateTransport()
        {
            Console.WriteLine("Created and selected a Road Logistics.");
            return new Truck();
        }
    }
}
