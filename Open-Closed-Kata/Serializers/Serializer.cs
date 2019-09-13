using System;
using System.Collections.Generic;
using System.Text;

namespace OC_Kata.Serializers
{
    public class Serializer
    {
        private readonly BaseSerializer _serializerType;

        public Serializer(BaseSerializer serializerType)
        {
            _serializerType = serializerType;
        }

        //private readonly IEnumerable<BaseSerializer> _serializations;

        //public Serializer(IEnumerable<BaseSerializer> serializations)
        //{
        //    _serializations = serializations;
        //}

        public string Serialize()
        {
            return _serializerType.Serialize();
            //throw new NotImplementedException();
        }
    }
}
