public class ReflectionActivity : Activity
{
    private static readonly string[] prompts = 
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private static readonly string[] questions = 
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?"
    };

    public ReflectionActivity() : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience.")
    {
    }

    public override void StartActivity()
    {
        base.StartActivity();

        Random random = new Random();
        string selectedPrompt = prompts[random.Next(prompts.Length)];
        Console.WriteLine(selectedPrompt);

        // Reflection activity specific logic
        foreach (var question in questions)
        {
            Console.WriteLine(question);
            Pause(4); // Pause to let the user reflect
        }

        EndActivity();
    }
}
