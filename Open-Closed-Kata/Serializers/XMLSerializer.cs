using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace OC_Kata.Serializers
{
    public class XMLSerializer<T> : BaseSerializer
    {
        public T Value { get; set; }
        
        public override string Serialize()
        {
            var typeInfo = typeof(T);
            //var xs = new XmlSerializer(typeInfo);
            //var tw = new StreamWriter(@"c:\temp\" + typeInfo.FullName + ".xml");
            //xs.Serialize(tw, Value);

            return "serialized " + typeInfo.FullName + ".xml";
        }
    }
}
