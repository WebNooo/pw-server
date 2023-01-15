using System;
namespace world.Network.Packets
{
	[PacketAttr(32)]
	public class UserLogin : Packet
	{
		string username;
		string password;

		public void Marshal()
		{

		}

        public void Unmarshal()
        {

        }
    }
}

