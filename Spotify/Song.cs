using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    internal class Song
    {
        public string Title { get; set; }
        public Artist Artist { get; set; }
        public Genre Genre { get; set; }
        public TimeSpan Duration { get; set; }

        public Song(string title, Artist artist, Genre genre, TimeSpan duration)
        {
            Title = title;
            Artist = artist;
            Genre = genre;
            Duration = duration;
        }
    }
}
