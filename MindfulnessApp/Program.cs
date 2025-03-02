class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness Program!");
        Console.WriteLine("Please choose an activity:");

        while (true)
        {
            Console.WriteLine("\n1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                var breathingActivity = new BreathingActivity();
                breathingActivity.StartActivity();
            }
            else if (choice == "2")
            {
                var reflectionActivity = new ReflectionActivity();
                reflectionActivity.StartActivity();
            }
            else if (choice == "3")
            {
                var listingActivity = new ListingActivity();
                listingActivity.StartActivity();
            }
            else if (choice == "4")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select again.");
            }
        }

        Console.WriteLine("Thank you for using the Mindfulness Program!");
    }
}
