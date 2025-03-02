public class ListingActivity : Activity
{
    private static readonly string[] prompts = 
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public override void StartActivity()
    {
        base.StartActivity();

        Random random = new Random();
        string selectedPrompt = prompts[random.Next(prompts.Length)];
        Console.WriteLine(selectedPrompt);

        // Countdown before they start listing
        Console.WriteLine("Think about it for a moment...");
        Pause(5);

        // Listing activity logic
        int itemCount = 0;
        DateTime startTime = DateTime.Now;

        while ((DateTime.Now - startTime).TotalSeconds < DurationInSeconds)
        {
            Console.WriteLine("Enter an item: ");
            string item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
            {
                itemCount++;
            }
        }

        Console.WriteLine($"You listed {itemCount} items.");
        EndActivity();
    }
}
