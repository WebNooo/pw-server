using System.Reflection;
using world.Network;

var packetsList = Assembly.GetExecutingAssembly().GetTypes()
    .Where(type => type.Namespace == "world.Network.Packets");
//.Select(type => type.Name);

var packets = new Dictionary<int, Type>(); 


foreach (var packet in packetsList)
{
    if (packet.GetCustomAttribute(typeof(PacketAttr)) is PacketAttr attribute)
    {
        packets.Add(attribute.opcode, packet);
    }
}

Console.WriteLine("Load packets: {0}", packets.Count);

int opcode = 35;

if (packets.ContainsKey(opcode))
{
    Console.WriteLine(packets[opcode].Name);
}
else
{
    Console.WriteLine("Unknown packet: {0}", opcode);
}

Console.ReadLine();