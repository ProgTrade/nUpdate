﻿// Author: Dominic Beger (Trade/ProgTrade)
// License: Creative Commons Attribution NoDerivs (CC-ND)
// Created: 01-08-2014 12:11
using System.IO;
using Newtonsoft.Json;

namespace nUpdate.Administration.Core
{
    public class Serializer
    {
        /// <summary>
        ///     Serializes a given serializable object.
        /// </summary>
        /// <param name="dataToSerialize">The data to serialize.</param>
        /// <returns>Returns the serialized data as a string.</returns>
        public static string Serialize(object dataToSerialize)
        {
            return JsonConvert.SerializeObject(dataToSerialize);
        }

        /// <summary>
        ///     Deserializes a given string.
        /// </summary>
        /// <typeparam name="T">The type that the deserializer should return. (Must be serializable)</typeparam>
        /// <param name="content">The data to deserialize.</param>
        /// <returns>Returns the data as given type in the type-argument.</returns>
        public static T Deserialize<T>(string content)
        {
            return JsonConvert.DeserializeObject<T>(content);
        }

        /// <summary>
        ///     Deserializes a string object from a stream.
        /// </summary>
        /// <typeparam name="T">The type that the deserializer should return. (Must be serializable)</typeparam>
        /// <param name="stream">The data to deserialize.</param>
        /// <returns>Returns the data as given type in the type-argument.</returns>
        public static T Deserialize<T>(Stream stream)
        {
            string streamContent;
            using (var reader = new StreamReader(stream))
            {
                streamContent = reader.ReadToEnd();
            }
            
            return JsonConvert.DeserializeObject<T>(streamContent);
        }
    }
}