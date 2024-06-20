using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    internal class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public List<Playlist> Playlists { get; set; }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
            Playlists = new List<Playlist>();
        }
    }

    //public class NormalUser : User
    //{
    //    public NormalUser(string username, string password) : base(username, password)
    //    {

    //    }
    //}

    //public class PremiumUser : User
    //{
    //    public PremiumUser(string username, string password) : base(username, password)
    //    {

    //    }
    //}

    //public class Student : PremiumUser
    //{
    //    public Student(string username, string password) : base(username, password)
    //    {
    //    }
    //}

    //public class Family : PremiumUser
    //{
    //    public Family(string username, string password) : base(username, password)
    //    {
    //    }
    //}
}

