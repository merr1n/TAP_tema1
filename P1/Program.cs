namespace P1
{
    internal class Program
    {

        static void premiumUser(standardUser user)
        {
            bool premium = true; ;
            while (premium == true)
            {
                Console.WriteLine("1. Unsubscribe");
                Console.WriteLine("2. Play Songs");
                Console.WriteLine("3. Exit");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {

                    case 1:
                        Data.Unsubscribe(user);
                        premium = false;
                        break;
                    case 2:
                        bool goOn = true;
                        int songCounter = 0;
                        IPlay pSong;
                        IPlay pAdd;
                        while (goOn == true)
                        {
                            songCounter++;
                            pSong = new PlaySong();
                            pSong.Say();
                            if (Console.ReadLine().ToString() == "0")
                                goOn = false;
                            if (songCounter == 30)
                                goOn = false;

                        }
                        break;
                    case 3:
                        premium = false;
                        break;
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }
            }
        }
        static void nonPremiumUser(standardUser user)
        {
            bool nonPremium = true; ;
            while (nonPremium == true)
            {
                Console.WriteLine("1. Subscribe");
                Console.WriteLine("2. Play Songs");
                Console.WriteLine("3. Exit");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option) {

                case 1:
                    Data.AddPremiumUser(user);
                    nonPremium = false;
                    break;
                case 2:
                    bool goOn = true;
                    int songCounter = 0;
                    IPlay pSong;
                    IPlay pAdd;
                    while (goOn == true)
                    {
                        songCounter++;
                        pSong = new PlaySong();
                        pSong.Say();
                        if (Console.ReadLine().ToString() == "0")
                            goOn = false;
                        if (songCounter % 3 == 0)
                        {
                            pAdd = new PlayAd();
                            pAdd.Say();
                            if (Console.ReadLine().ToString() == "0")
                                goOn = false;
                        }
                        if (songCounter == 30)
                            goOn = false;

                    }
                    break;
                case 3:
                    nonPremium = false;
                    break;
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }
            }
        }

        static void Main(string[] args)
        {
            var user = new standardUser("dan", "123", "dan@gmail.com", 30);
            Data.standards.Add(user);
            Console.WriteLine(user.Name);
            Console.WriteLine(Data.premiumUsers.Count());
            //Data.AddPremiumUser(user);
            Console.WriteLine(Data.premiumUsers.Count());
            var artist = new artistUser("madona", "aa", "marona", "Lady Gaga");
            bool goOn = true, simulate=true;
            int songCounter = 0;
            IPlay pAdd;
            IPlay pSong;
            //SE DECLARA LA INCEPUT UN USER CARE SA FIE NON PREMIUM SI UN ARTIST SI APOI SE APELEAZA IN FUNCTIE DE CE DORIM FUNCTIILE

            while (simulate == true)
            {
                Console.WriteLine("1. Roleplay as a standard non-premium user.");
                Console.WriteLine("2. Roleplay as premium user.");
                Console.WriteLine("3. Create songs as artist.");
                Console.WriteLine("4. See songs list.");
                Console.WriteLine("5. See premium users.");
                Console.WriteLine("6. See non-premium users.");
                Console.WriteLine("7. Exit.");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {

                    case 1:
                        if (user.Premium == false)
                            nonPremiumUser(user);
                        else
                            Console.WriteLine("No standard users");
                        break;
                    case 2:
                        if (user.Premium == true)
                            premiumUser(user);
                        else
                            Console.WriteLine("No premium users");
                        break;
                    case 3:
                        artist.createSong();
                        break;
                    case 4:
                        Data.SeeSongs();
                        break;
                    case 5:
                        Data.SeePremiumUsers();
                        break;
                    case 6:
                        Data.SeeStandardUsers();
                        break;
                    case 7:
                        simulate = false;
                        break;
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }
            }
        }
    }
}
