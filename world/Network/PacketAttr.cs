using System;

namespace world.Network
{
    [AttributeUsage(AttributeTargets.Class)]
    public class PacketAttr : Attribute {
		public int opcode { get; set; }

		public PacketAttr(int opcode)
		{
			this.opcode = opcode;
		}
	}
}

