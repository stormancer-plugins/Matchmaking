using System;
using System.IO;

namespace Stormancer.Server.Matchmaking
{
    public interface IMatchmakingResolutionWriterContext
    {
       
        ISerializer Serializer { get; }
        void WriteToStream(Action<Stream> writer);
        void WriteObjectToStream<T>(T data);
    }
}