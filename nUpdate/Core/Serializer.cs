﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Web.Script.Serialization;

namespace nUpdate.Core
{
    internal class Serializer
    {
        /// <summary>
        /// Serializes a given serializable object.
        /// </summary>
        /// <param name="dataToSerialize">The data to serialize.</param>
        /// <returns>Returns the serialized data as a string.</returns>
        public static string Serialize(object dataToSerialize)
        {
            var serializer = new JavaScriptSerializer();
            return serializer.Serialize(dataToSerialize);
        }

        /// <summary>
        /// Deserializes a given string.
        /// </summary>
        /// <typeparam name="T">The type that the deserializer should return. (Must be serializable)</typeparam>
        /// <param name="dataToDeserialize">The data to deserialize.</param>
        /// <returns>Returns the data as given type in the type-argument.</returns>
        public static T Deserialize<T>(string dataToDeserialize) 
        {
            var serializer = new JavaScriptSerializer();
            return serializer.Deserialize<T>(dataToDeserialize);
        }
    }
}
