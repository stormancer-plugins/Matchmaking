﻿using Stormancer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stormancer.Matchmaking
{
    public class App
    {
        public void Run(IAppBuilder builder)
        {
            builder.AddPlugin(new MatchmakingPlugin());
        }
    }
}
