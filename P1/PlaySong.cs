using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1
{
    internal class PlaySong : IPlay
    {
        public void Say()
        {
            Random rand = new Random();
            int index = rand.Next(0, Data.allSongs.Count);
            Console.WriteLine(Data.allSongs[index]);
        }
    }
}
