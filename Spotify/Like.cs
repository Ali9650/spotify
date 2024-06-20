using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    internal class Like
    {
        public User User { get; set; }
        public Song Song { get; set; }

        public Like(User user, Song song)
        {
            User = user;
            Song = song;
        }
    }
}
