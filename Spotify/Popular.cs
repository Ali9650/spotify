using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    internal class Popular
    {
        public List<Song> GetPopularSongs(List<Song> songs)
        {
            // In a real application, this would be based on metrics such as likes, plays, etc.
            return songs.OrderByDescending(s => s.Title).Take(10).ToList();
        }
    }
}
