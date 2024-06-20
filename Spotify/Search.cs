using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    internal class Search
    {
        public List<Song> SearchSongsByTitle(List<Song> songs, string title)
        {
            return songs.Where(s => s.Title.Contains(title)).ToList();
        }
    }
}
