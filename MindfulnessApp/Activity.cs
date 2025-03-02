public class Activity
{
    public string ActivityName { get; set; }
    public string ActivityDescription { get; set; }
    public int DurationInSeconds { get; set; }

    public Activity(string activityName, string activityDescription)
    {
        ActivityName = activityName;
        ActivityDescription = activityDescription;
    }

    public virtual void StartActivity()
    {
        // Common starting message logic
        Console.WriteLine($"Starting {ActivityName}: {ActivityDescription}");
        Console.WriteLine($"Please set the duration (in seconds): ");
        DurationInSeconds = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready...");
        Pause(3);  // Pause before starting the activity
    }

    public virtual void EndActivity()
    {
        Console.WriteLine("Great job!");
        Console.WriteLine($"You completed {ActivityName} for {DurationInSeconds} seconds.");
        Pause(3);  // Pause before finishing
    }

    protected void Pause(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            System.Threading.Thread.Sleep(1000); // Sleep for 1 second to simulate the pause
        }
        Console.WriteLine();
    }
}
