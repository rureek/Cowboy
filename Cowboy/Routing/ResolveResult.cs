﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cowboy.Routing
{
    public class ResolveResult
    {
        public Route Route { get; set; }

        public DynamicDictionary Parameters { get; set; }

        public Func<Context, Exception, dynamic> OnError { get; set; }

        public ResolveResult()
        {
        }

        public ResolveResult(Route route, DynamicDictionary parameters, Func<Context, Exception, dynamic> onError)
        {
            this.Route = route;
            this.Parameters = parameters;
            this.OnError = onError;
        }
    }
}