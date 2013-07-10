using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DALService.Tools
{
    public class Json
    {
        private Json() { }

        /// <summary>
        /// JSON 序列化
        /// </summary>
        /// <param name="ObjectToSerializer">序列化的对象</param>
        /// <returns>JSON</returns>
        public static string Serializer(object ObjectToSerializer)
        {
            JsonFx.Json.JsonWriter jsonWriter = new JsonFx.Json.JsonWriter();

            return jsonWriter.Write(ObjectToSerializer);
        }

        /// <summary>
        /// JSON 反序列化
        /// </summary>
        /// <param name="ObjectToDeserializer">JSON字符串形式表示的对象</param>
        /// <param name="ObjectType">对象的类型</param>
        /// <returns>对象</returns>
        public static object Deserializer(string ObjectToDeserializer, Type ObjectType)
        {
            JsonFx.Json.JsonReader jsonReader = new JsonFx.Json.JsonReader();

            return jsonReader.Read(ObjectToDeserializer, ObjectType);
        }
    }
}
