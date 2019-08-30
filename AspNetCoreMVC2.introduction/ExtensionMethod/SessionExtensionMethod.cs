using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMVC2.introduction.ExtensionMethod
{
    public static class SessionExtensionMethod
    {
        public static void SetObject(this ISession session,string key,object value)
        {
            string objectString = JsonConvert.SerializeObject(value);
            session.SetString(key, objectString);
        }

        public static T GetObject<T>(this ISession session, string key) where T:class
        {

            string ObjectString = session.GetString(key);
            if (string.IsNullOrEmpty(ObjectString))
            {
                return null;
            }
            T valueToDeserialize = JsonConvert.DeserializeObject<T>(ObjectString);
            return valueToDeserialize;

        }
    }
}
