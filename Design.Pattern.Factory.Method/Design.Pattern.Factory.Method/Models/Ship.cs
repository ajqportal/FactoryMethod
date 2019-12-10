using System;
using System.Collections.Generic;
using System.Text;
using Design.Pattern.Factory.Method.Interface;

namespace Design.Pattern.Factory.Method.Models
{
    public class Ship : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("You are delivering with a ship.");
        }
    }
}
