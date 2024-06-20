using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    internal class Login
    {
        public bool Authenticate(User user, string password)
        {
            return user.Password == password;
        }
    }
}
