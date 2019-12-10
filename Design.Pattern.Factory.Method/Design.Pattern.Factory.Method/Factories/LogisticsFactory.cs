using System;
using System.Collections.Generic;
using System.Text;
using Design.Pattern.Factory.Method.Business;
using Design.Pattern.Factory.Method.Interface;

namespace Design.Pattern.Factory.Method.Factories
{
    public static class LogisticsFactory
    {
        public static ILogistics SelectLogistics<T>() where T : ILogistics, new()
        {
            return new T();
        }
    }
}
