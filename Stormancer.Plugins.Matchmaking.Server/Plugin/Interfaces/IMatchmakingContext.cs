using Stormancer.Plugins;
using System;

namespace Stormancer.Server.Matchmaking
{
    public interface IMatchmakingContext
    {
        DateTime CreationTimeUTC { get; }

        Group Group { get; set; }
    }
}