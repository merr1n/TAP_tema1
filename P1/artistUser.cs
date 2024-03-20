using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1
{
    internal class artistUser : baseUser
    {
        public string SceneName { get; set; }

        public artistUser(string name, string password, string email, string sceneName) : base(name, password, email, true) 
        {
            SceneName = sceneName;
        }

        public void createSong()
        {
            string name = Console.ReadLine();
            Data.AddSong(name, SceneName);
        }
    }
}
