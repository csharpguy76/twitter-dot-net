using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter.Library
{
    public static class Followers
    {
        public static id_list Ids(string screenName)
        {
            var url = string.Format("https://api.twitter.com/1/followers/ids.xml?screen_name={0}", screenName);
            var obj = SerializerHelper.Deserialize(url, typeof(id_list));
            var item = obj as id_list;
            return item;
        }


    }
}
