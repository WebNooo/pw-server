using System;

namespace world.Network
{
	public class Packet
	{
        int opcode { get; set; }

		public Packet()
		{

        }

        public int pack()
        {
            return 0;
        }


        public void GetAttrbute(Type t)
        {
            if (Attribute.GetCustomAttribute(t, typeof(PacketAttr)) is PacketAttr attribute)
            {
                opcode = attribute.opcode;
            }
        }

        //public T unpack<T>()
        //{
        //    return T;
        //}
    }
}

