namespace Spotify
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var artist1 = new Artist("The Beatles");
            var artist2 = new Artist("Taylor Swift");
            var artist3 = new Artist("Drake");
            var artist4 = new Artist("Ed Sheeran");
            var artist5 = new Artist("Adele");
            var artist6 = new Artist("Queen");
            var artist7 = new Artist("Beyoncé");
            var artist8 = new Artist("Coldplay");
            var artist9 = new Artist("Kendrick Lamar");
            var artist10 = new Artist("Billie Eilish");

            var song1 = new Song("Hey Jude", artist1, new Genre("Rock"), new TimeSpan(0, 7, 11));
            var song2 = new Song("Love Story", artist2, new Genre("Country"), new TimeSpan(0, 3, 55));
            var song3 = new Song("God's Plan", artist3, new Genre("Hip-Hop"), new TimeSpan(0, 3, 18));
            var song4 = new Song("Shape of You", artist4, new Genre("Pop"), new TimeSpan(0, 3, 53));
            var song5 = new Song("Rolling in the Deep", artist5, new Genre("Soul"), new TimeSpan(0, 3, 48));
            var song6 = new Song("Bohemian Rhapsody", artist6, new Genre("Rock"), new TimeSpan(0, 5, 55));
            var song7 = new Song("Halo", artist7, new Genre("Pop"), new TimeSpan(0, 3, 44));
            var song8 = new Song("Fix You", artist8, new Genre("Alternative"), new TimeSpan(0, 4, 55));
            var song9 = new Song("HUMBLE.", artist9, new Genre("Hip-Hop"), new TimeSpan(0, 2, 57));
            var song10 = new Song("Bad Guy", artist10, new Genre("Pop"), new TimeSpan(0, 3, 14));

            var playlist1 = new Playlist("Rock Classics");
            playlist1.AddSong(song1);
            playlist1.AddSong(song6);

            var playlist2 = new Playlist("Today's Top Hits");
            playlist2.AddSong(song2);
            playlist2.AddSong(song4);
            playlist2.AddSong(song7);
            playlist2.AddSong(song9);
            playlist2.AddSong(song10);

            var playlist3 = new Playlist("Hip-Hop Essentials");
            playlist3.AddSong(song3);
            playlist3.AddSong(song9);

            var playlist4 = new Playlist("Chill Hits");
            playlist4.AddSong(song4);
            playlist4.AddSong(song8);
            playlist4.AddSong(song10);

            var playlist5 = new Playlist("Pop Rising");
            playlist5.AddSong(song2);
            playlist5.AddSong(song4);
            playlist5.AddSong(song7);

            var user = new User("user1", "password1");
            user.Playlists.Add(playlist1);
            user.Playlists.Add(playlist2);
            user.Playlists.Add(playlist3);
            user.Playlists.Add(playlist4);
            user.Playlists.Add(playlist5);

            // User Login
            var login = new Login();
            bool isAuthenticated = login.Authenticate(user, "password1");

            if (isAuthenticated)
            {
                Console.WriteLine("User authenticated!");

                int choice = -1;
                while (choice != 0)
                {
                    ShowMenu();
                    choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            DisplayPlaylists(user.Playlists);
                            break;
                        case 2:
                            ShufflePlaylist(user.Playlists);
                            break;
                        case 3:
                            SearchSongs(user.Playlists.SelectMany(p => p.Songs).ToList());
                            break;
                        case 4:
                            DisplayPopularSongs(user.Playlists.SelectMany(p => p.Songs).ToList());
                            break;
                        case 0:
                            Console.WriteLine("Exiting...");
                            break;
                        default:
                            Console.WriteLine("Invalid choice, please try again.");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Authentication failed!");
            }

            Console.ReadLine();
        }

        static void ShowMenu()
        {
            Console.WriteLine("\n--- Spotify Console Menu ---");
            Console.WriteLine("1. Display Playlists");
            Console.WriteLine("2. Shuffle Playlists");
            Console.WriteLine("3. Search Songs");
            Console.WriteLine("4. Display Popular Songs");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice: ");
        }

        static void DisplayPlaylists(List<Playlist> playlists)
        {
            foreach (var playlist in playlists)
            {
                Console.WriteLine($"\nPlaylist: {playlist.Name}");
                foreach (var song in playlist.Songs)
                {
                    Console.WriteLine($"- {song.Title} by {song.Artist.Name}");
                }
            }
        }

        static void ShufflePlaylist(List<Playlist> playlists)
        {
            foreach (var playlist in playlists)
            {
                playlist.Shuffle();
                Console.WriteLine($"\nPlaylist '{playlist.Name}' shuffled!");
            }
        }

        static void SearchSongs(List<Song> songs)
        {
            Console.Write("\nEnter song title to search: ");
            string title = Console.ReadLine();
            var search = new Search();
            var results = search.SearchSongsByTitle(songs, title);

            if (results.Any())
            {
                Console.WriteLine("\nSearch Results:");
                foreach (var song in results)
                {
                    Console.WriteLine($"- {song.Title} by {song.Artist.Name}");
                }
            }
            else
            {
                Console.WriteLine("No songs found with the given title.");
            }
        }

        static void DisplayPopularSongs(List<Song> songs)
        {
            var popular = new Popular();
            var popularSongs = popular.GetPopularSongs(songs);

            Console.WriteLine("\nPopular Songs:");
            foreach (var song in popularSongs)
            {
                Console.WriteLine($"- {song.Title} by {song.Artist.Name}");
            }
        }
    }
}
        
    

