var Festival = new ArtistService(new swaggerRepository());


while (true)
{
    Console.WriteLine("Menu:");
    Console.WriteLine("1. Get all artists");
    Console.WriteLine("2. Get all concerts");
    Console.WriteLine("3. Get artists and their concerts");
    Console.WriteLine("4. Exit");
    Console.Write("Enter your choice: ");

    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            var artists = await Festival.GetAllArtists();
            foreach (var artist in artists)
            {
                Console.WriteLine(artist.Name);
            }
            break;
        case "2":
            var concerts = await Festival.GetAllConcerts();
            foreach (var concert in concerts)
            {
                Console.WriteLine(concert.Name);
            }
            break;
        case "3":
            Console.Write("Enter artist name: ");
            string artistName = Console.ReadLine();
            var artistConcerts = await Festival.GetArtistWithConcerts(artistName);
            if (artistConcerts == null)
            {
                Console.WriteLine("Artist not found.");
            }
            else
            {
                Console.WriteLine(artistConcerts);
            }
            break;
        case "4":
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid choice. Please try again.");
            break;
    }

    Console.WriteLine(); // Add a new line for better formatting
}