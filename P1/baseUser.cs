using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1
{
    internal abstract class baseUser
    {

        public List<string> Playlist = new List<string>();
        public Guid Id { get; private set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }   
        public bool Premium { get; set; }

        public baseUser(string name, string password, string email, bool premium)
        {
            Id = Guid.NewGuid();
            Name = name;
            Password = password;
            Email = email;
            Premium = premium;
        }

        public void AddSongToPlaylist(string song)
        {
            if (Data.allSongs.Contains(song))
                Playlist.Add(song);
            else
                Console.WriteLine("The song " + song + " doesn't exist!");
        }
    }
}
