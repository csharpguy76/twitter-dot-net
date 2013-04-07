using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Twitter.Library
{
    public static class Users
    {
        /// <summary>
        /// Lookup method returns a list of user's Twitter profile.
        /// </summary>
        /// <param name="values">mutliple user's screen name separated by commas.</param>
        /// <returns>returns a list of users.</returns>
        public static users Lookup(string values)
        {
            var url = string.Format("https://api.twitter.com/1/users/lookup.xml?screen_name={0}&include_entities=true", values);
            var obj = SerializerHelper.Deserialize(url, typeof(users));
            var item = obj as users;
            return item;
        }

        /// <summary>
        /// Show method return user's Twitter profile.
        /// </summary>
        /// <param name="value">string value of the user's screen name</param>
        /// <returns>returns a user object</returns>
        public static user Show(string value)
        {
            var url = string.Format("https://api.twitter.com/1/users/show.xml?screen_name={0}&include_entities=true", value);
            var obj = SerializerHelper.Deserialize(url, typeof(user));
            var item = obj as user;
            return item;
        }
    }
}
