﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OC_Kata.Serializers
{
    public class JSONSerilizer<T> : BaseSerializer
    {
        public T Value { get; set; }

        public override string Serialize()
        {
            var typeInfo = typeof(T);

            //TODO

            return "serialized " + typeInfo.FullName + ".json";
        }
    }
}
