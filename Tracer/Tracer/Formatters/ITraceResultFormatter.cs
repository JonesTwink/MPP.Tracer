﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tracer.Formatters
{
    public interface ITraceResultFormatter
    {
        void Format(TraceResult traceResult);
    }
}
