using OC_Kata.Pocos;
using OC_Kata.Serializers;
using System;
using System.Collections.Generic;

namespace OC_Kata
{
    class Program
    {
        static void Main(string[] args)
        {
            var settings_xml = new XMLSerializer<Settings>();
            var config_xml = new XMLSerializer<Config>();
            var data_json = new JSONSerilizer<Data>();
            var content_json = new JSONSerilizer<Content>();
            var content_binary = new BinarySerializer<BinaryContent>();

            Console.WriteLine(new Serializer(settings_xml).Serialize());
            Console.WriteLine(new Serializer(config_xml).Serialize());
            Console.WriteLine(new Serializer(data_json).Serialize());
            Console.WriteLine(new Serializer(content_json).Serialize());
            Console.WriteLine(new Serializer(content_json).Serialize());
            Console.WriteLine(new Serializer(content_binary).Serialize());

            Console.WriteLine("Type any key to exit..");
            Console.ReadLine();
        }
    }
}
