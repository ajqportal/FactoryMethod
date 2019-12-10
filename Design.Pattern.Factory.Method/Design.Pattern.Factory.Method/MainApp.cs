using System;
using Design.Pattern.Factory.Method.Business;
using Design.Pattern.Factory.Method.Factories;

namespace Design.Pattern.Factory.Method
{
    class MainApp
    {
        static void Main(string[] args)
        {
            var logisticsFactory = LogisticsFactory.SelectLogistics<SeaLogistics>().CreateTransport();
            logisticsFactory.Deliver();
        }
    }
}
