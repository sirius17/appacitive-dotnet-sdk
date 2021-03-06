﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Appacitive.Sdk.Services;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections;

namespace Appacitive.Sdk.Services
{
    public class AtomicCountersRequestConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return typeof(AtomicCountersRequest) == objectType;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var request = value as AtomicCountersRequest;
            if (request == null)
            {
                writer.WriteNull();
                return;
            }

            writer.WriteStartObject();
            writer.WritePropertyName(request.Property );
            writer.WriteStartObject();
            if( request.IncrementBy > 0 )
                writer.WriteProperty("incrementby", request.IncrementBy.ToString());
            if( request.DecrementBy > 0 )
                writer.WriteProperty("decrementby", request.DecrementBy.ToString());
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }

}
