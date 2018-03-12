using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stormancer.Server.Matchmaking
{
    public class Player
    {
        public Player(string userId)
        {
            UserId = userId;
        }
        public string UserId { get; private set; }

        public object Data { get; set; }
    }
}
