using System;
namespace world.Network.Packets
{
	[PacketAttr(33)]
	public class UserLogout : Packet
	{
		bool success;
	}
}

