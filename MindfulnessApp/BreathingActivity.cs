public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly.")
    {
    }

    public override void StartActivity()
    {
        base.StartActivity();

        // Breathing activity specific logic
        for (int i = 0; i < DurationInSeconds; i++)
        {
            Console.WriteLine("Breathe in...");
            Pause(3);  // Pause to simulate breathing in
            Console.WriteLine("Breathe out...");
            Pause(3);  // Pause to simulate breathing out
        }

        EndActivity();
    }
}
