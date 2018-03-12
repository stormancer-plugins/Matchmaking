using System.Threading.Tasks;
using Stormancer.Plugins;
using Stormancer.Configuration;

namespace Stormancer.Server.Matchmaking
{
    public interface IMatchmakingDataExtractor 
    {
        Task<bool> ExtractData(string provider, RequestContext<IScenePeerClient> request, Group group);
    }
}