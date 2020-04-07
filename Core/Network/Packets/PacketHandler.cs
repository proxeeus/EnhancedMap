﻿using System;
using Spawn.Core.Network.Packets;

namespace Spawn.Core.Network
{
    /*public delegate void OnPacketReceive(PacketReader pvSrc);

    public sealed class PacketHandler
    {
        public PacketHandler(int packetId, OnPacketReceive onReceive)
        {
            PacketId = packetId;
            OnReceive = onReceive;
        }

        public int PacketId { get; }

        public OnPacketReceive OnReceive { get; }
    }*/

    public class PacketHandler
    {
        public PacketHandler(Action<Packet> callback)
        {
            Callback = callback;
        }

        public Action<Packet> Callback { get; }
    }
}