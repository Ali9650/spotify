using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    internal class Playlist
    {
        public string Name { get; set; }
        public List<Song> Songs { get; private set; }

        public Playlist(string name)
        {
            Name = name;
            Songs = new List<Song>();
        }

        public void AddSong(Song song)
        {
            Songs.Add(song);
        }

        public void Shuffle()
        {
            Random rng = new Random();
            int n = Songs.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                var value = Songs[k];
                Songs[k] = Songs[n];
                Songs[n] = value;
            }
        }
    }
}
