using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1
{
    internal static class Data
    {
        public static List<standardUser> premiumUsers = new List<standardUser>();

        public static List<standardUser> standards = new List<standardUser>();

        public static List<string> allSongs = new List<string> { "Shape of You - Ed Sheeran",
    "Bohemian Rhapsody - Queen",
    "Billie Jean - Michael Jackson",
    "Rolling in the Deep - Adele",
    "Hotel California - Eagles",
    "Smells Like Teen Spirit - Nirvana",
    "Hey Jude - The Beatles",
    "Uptown Funk - Mark Ronson ft. Bruno Mars",
    "Sweet Child o' Mine - Guns N' Roses",
    "Every Breath You Take - The Police",
    "Thriller - Michael Jackson",
    "Let It Be - The Beatles",
    "Don't Stop Believin' - Journey",
    "Someone Like You - Adele",
    "Stairway to Heaven - Led Zeppelin",
    "Wonderwall - Oasis",
    "I Will Always Love You - Whitney Houston",
    "Thinking Out Loud - Ed Sheeran",
    "Lose Yourself - Eminem",
    "Hallelujah - Jeff Buckley",
    "Piano Man - Billy Joel",
    "Radioactive - Imagine Dragons",
    "Dancing Queen - ABBA",
    "Wish You Were Here - Pink Floyd",
    "All of Me - John Legend",
    "Creep - Radiohead",
    "Let Her Go - Passenger",
    "Shape of My Heart - Sting",
    "Yesterday - The Beatles",
    "Bohemian Like You - The Dandy Warhols",
    "Clocks - Coldplay",
    "My Heart Will Go On - Celine Dion",
    "Sweet Home Alabama - Lynyrd Skynyrd",
    "Take Me to Church - Hozier",
    "Titanium - David Guetta ft. Sia",
    "I Want to Hold Your Hand - The Beatles",
    "Thunderstruck - AC/DC",
    "Say Something - A Great Big World ft. Christina Aguilera",
    "Nothing Else Matters - Metallica",
    "Under Pressure - Queen ft. David Bowie",
    "Highway to Hell - AC/DC",
    "The Sound of Silence - Simon & Garfunkel",
    "Don't You Want Me - The Human League",
    "Shape of You - Ed Sheeran",
    "With or Without You - U2",
    "Eye of the Tiger - Survivor",
    "Hurt - Johnny Cash",
    "Take On Me - a-ha",
    "Fix You - Coldplay",
    "Angels - Robbie Williams"};

        public static List<string> Ad = new List<string> { "Want a break from the ads? Watch this short video to receive 30 minutes of ad free music. (guitar playing)", "Want a break from the ads? If you tap now to watch a short video you'll recieve 30 minutes of ad free music.", "Listen to music without interruptions! Get Premium now and enjoy ad-free streaming on Spotify.", "Losing the vibe with this ad? Upgrade to Premium and enjoy uninterrupted music on Spotify." };



        public static void AddPremiumUser(standardUser user)
        {
            Console.WriteLine("4 Subscriptions available: ");
            Console.WriteLine("1. Premium Individual: 24,00 RON/luna ");
            Console.WriteLine("2. Premium Duo: 31,00 RON/luna");
            Console.WriteLine("3. Premium Family: 38,00 RON/luna");
            Console.WriteLine("4. Premium Student: 13,00 RON/luna");

            int option = Convert.ToInt32(Console.ReadLine());

            if (!premiumUsers.Contains(user)) { 
            switch(option)
            {
                case 1:
                    Console.WriteLine("You chose the 'Premium Individual' option!");
                    if (user.Wallet < 24)
                        Console.WriteLine("Looks like you don't have enough funds.");
                    else
                    {
                        user.Premium = true;
                        user.Subscription = "Premium Individual";
                        premiumUsers.Add(user);
                        standards.Remove(user);
                    }
                    break;
                    case 2: Console.WriteLine("You chose the 'Premium Duo' option!");
                    if (user.Wallet < 31)
                        Console.WriteLine("Looks like you don't have enough funds.");
                    else
                    {
                        user.Premium = true;
                        user.Subscription = "Premium Duo";
                        premiumUsers.Add(user);
                            standards.Remove(user);
                        }
                    break;
                    case 3: Console.WriteLine("You chose the 'Premium Family' option!");
                    if (user.Wallet < 38)
                        Console.WriteLine("Looks like you don't have enough funds.");
                    else
                    {
                        user.Premium = true;
                        user.Subscription = "Premium Family";
                        premiumUsers.Add(user);
                            standards.Remove(user);
                        }
                    break;
                    case 4: Console.WriteLine("You chose the 'Premium Student' option!");
                    if (user.Student == true)
                    {
                        if (user.Wallet < 13)
                            Console.WriteLine("Looks like you don't have enough funds.");
                        else
                        {
                            user.Premium = true;                      user.Subscription = "Premium Student";
                            premiumUsers.Add(user);
                                standards.Remove(user);
                            }
                    }
                    else
                        Console.WriteLine("Your account isn't set up to be a Student's one! If you are a Student, set it up first!"); //The code for this doesnt exist yet so only this message appears//
                    break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;

            }
            }
        }

        public static void Unsubscribe(standardUser user)
        {
            if(user!=null)
            {
                user.Subscription = "Standard";
                user.Premium = false;
                standards.Add( user );
                int indexOfUser = premiumUsers.IndexOf(user);
                premiumUsers.RemoveAt(indexOfUser);
            }
        }

        public static void AddSong(string song, string scenename)
        {
            allSongs.Add(song+" - "+scenename);
        }

        public static void SeeSongs()
        {
            for(int i=0;i<allSongs.Count;i++)
            {
                Console.WriteLine((i + 1) + ": " + allSongs[i]);
            }
        }

        public static void SeePremiumUsers()
        {
            if (premiumUsers.Count() > 0)
            {
                for (int i = 0; i < premiumUsers.Count; i++)
                {
                    Console.WriteLine((i + 1) + ": " + premiumUsers[i].Name);
                }
            }
            else
                Console.WriteLine("No premium users");
        }

        public static void SeeStandardUsers()
        {
            if (standards.Count() > 0)
            {
                for (int i = 0; i < standards.Count; i++)
                {
                    Console.WriteLine((i + 1) + ": " + standards[i].Name);
                }
            }
            else
                Console.WriteLine("No standard users");
        }
    }
}
