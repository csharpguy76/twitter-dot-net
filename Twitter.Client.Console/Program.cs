using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter.Client.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = Twitter.Library.Users.Show("david_loo");
            System.Console.WriteLine(user.name);
            System.Console.WriteLine(user.location);
            System.Console.WriteLine(user.followers_count.ToString());
            System.Console.WriteLine(user.url);
            System.Console.WriteLine(user.notifications);
            System.Console.WriteLine(user.friends_count.ToString());
            System.Console.ReadKey();
        }
    }
}
