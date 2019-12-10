﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Pattern.Factory.Method.Interface
{
    public interface ILogistics
    {
        ITransport CreateTransport();
    }
}
