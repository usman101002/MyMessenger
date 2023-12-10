using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MyMessenger
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //    Message msg = new Message();
        //    Console.WriteLine(msg.ToString());

        var msg = new Message("Usman", "Privet", DateTime.Now);
        var output = JsonConvert.SerializeObject(msg);
        Console.WriteLine(output);

        var deserializedMessage = JsonConvert.DeserializeObject<Message>(output);
        Console.WriteLine(deserializedMessage);
        }
    }
}
