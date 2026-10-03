using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base(
        "Breathing Activity",
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing."
        )
    {
        
    }

    public void Run()
    {
        StartingMessage();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            TimeSpan remainingTime = endTime - DateTime.Now;
            int secondsLeft = (int)Math.Ceiling(remainingTime.TotalSeconds);

            if (secondsLeft <= 0)
            {
                break;
            }

            int breathSeconds = Math.Min(5, secondsLeft);

            Console.WriteLine("Breathe in...");
            ShowCountDown(breathSeconds);

            remainingTime = endTime - DateTime.Now;
            secondsLeft = (int)Math.Ceiling(remainingTime.TotalSeconds);

            if (secondsLeft <= 0)
            {
                break;
            }

            breathSeconds = Math.Min(5, secondsLeft);

            Console.WriteLine("Breathe out...");
            ShowCountDown(breathSeconds);
        }

        EndingMessage();

    }
}