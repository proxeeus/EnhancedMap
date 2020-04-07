using System;
using Spawn.Core.Network;

namespace Spawn.Core
{
    public struct ResponseServerEntry
    {
        public ServerMessageType Type;
        public string Message;
    }

    public sealed class EventSink
    {
        public static event EventHandler<ResponseServerEntry> ServerResponseMessageEvent;

        public static void InvokeServerResponseMessage(ResponseServerEntry e)
        {
            ServerResponseMessageEvent.Raise(e);
        }
    }
}