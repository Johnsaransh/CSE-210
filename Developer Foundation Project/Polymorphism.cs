using System;

abstract class Activity
{
    public DateTime Date { get; set; }
    public int Duration { get; set; } // Duration in minutes

    public Activity(DateTime date, int duration)
    {
        Date = date;
        Duration = duration;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public abstract string GetSummary();
}

class Running : Activity
{
    public double Distance { get; set; } // in miles

    public Running(DateTime date, int duration, double distance)
        : base(date, duration)
    {
        Distance = distance;
    }

    public override double GetDistance()
    {
        return Distance;
    }

    public override double GetSpeed()
    {
        return Distance / Duration * 60; // miles per hour
    }

    public override double GetPace()
    {
        return Duration / Distance; // minutes per mile
    }

    public override string GetSummary()
    {
        return $"{Date.ToShortDateString()} Running ({Duration} min): Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}

class Cycling : Activity
{
    public double Speed { get; set; } // in miles per hour

    public Cycling(DateTime date, int duration, double speed)
        : base(date, duration)
    {
        Speed = speed;
    }

    public override double GetDistance()
    {
        return Speed * Duration / 60; // miles
    }

    public override double GetSpeed()
    {
        return Speed;
    }

    public override double GetPace()
    {
        return 60 / Speed; // minutes per mile
    }

    public override string GetSummary()
    {
        return $"{Date.ToShortDateString()} Cycling ({Duration} min): Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}

class Swimming : Activity
{
    public int Laps { get; set; }

    public Swimming(DateTime date, int duration, int laps)
        : base(date, duration)
    {
        Laps = laps;
    }

    public override double GetDistance()
    {
        return Laps * 50.0 / 1000.0; // in kilometers
    }

    public override double GetSpeed()
    {
        return GetDistance() / Duration * 60; // km per hour
    }

    public override double GetPace()
    {
        return Duration / GetDistance(); // minutes per kilometer
    }

    public override string GetSummary()
    {
        return $"{Date.ToShortDateString()} Swimming ({Duration} min): Distance {GetDistance()} km, Speed {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Activity[] activities = new Activity[]
        {
            new Running(DateTime.Now, 30, 3),
            new Cycling(DateTime.Now, 45, 12),
            new Swimming(DateTime.Now, 60, 30)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
