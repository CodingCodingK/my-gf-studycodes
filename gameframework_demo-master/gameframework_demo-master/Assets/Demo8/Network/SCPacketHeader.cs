using System;
using ProtoBuf;

namespace StarForce
{
    [Serializable, ProtoContract(Name = @"SCPacketHeader")]
    public sealed class SCPacketHeader : PacketHeaderBase
    {
        /* 注意,ProtoMember是木头加上的,以便可以使用protobuf序列化 */
        [ProtoMember (1)]
        public override int Id
        {
            get;
            set;
        }

        /* 注意,ProtoMember是木头加上的,以便可以使用protobuf序列化 */
        [ProtoMember (2)]
        public override int PacketLength
        {
            get;
            set;
        }

        public override PacketType PacketType
        {
            get
            {
                return PacketType.ServerToClient;
            }
        }
    }
}
