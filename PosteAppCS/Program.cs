using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosteAppCS
{

    class MesageApp
    {
        private List<string> friendsPost = new List<string>();

        public void addFriend(string name)
        {
            this.friendsPost.Add(name);

        }

        public string showFriends()
        {

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
