using MsgPack.Serialization;

namespace Stormancer.Matchmaking
{
    [MessagePackEnum(SerializationMethod = EnumSerializationMethod.ByUnderlyingValue)]
    public enum MatchmakingStatusUpdate
    {
        SearchStart = 0,
        CandidateFound = 1,
        WaitingPlayersReady = 2,
        Success = 3,
        Failed = 4,
        Cancelled = 5
    }
}
