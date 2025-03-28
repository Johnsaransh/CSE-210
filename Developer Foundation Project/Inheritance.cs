using System;

class Address
{
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }

    public Address(string street, string city, string state, string country)
    {
        Street = street;
        City = city;
        State = state;
        Country = country;
    }

    public string GetFullAddress()
    {
        return $"{Street}, {City}, {State}, {Country}";
    }
}

class Event
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime Date { get; set; }
    public string Time { get; set; }
    public Address EventAddress { get; set; }

    public Event(string title, string description, DateTime date, string time, Address address)
    {
        Title = title;
        Description = description;
        Date = date;
        Time = time;
        EventAddress = address;
    }

    public virtual void DisplayStandardDetails()
    {
        Console.WriteLine($"Title: {Title}\nDescription: {Description}\nDate: {Date}\nTime: {Time}\nAddress: {EventAddress.GetFullAddress()}");
    }
}

class Lecture : Event
{
    public string Speaker { get; set; }
    public int Capacity { get; set; }

    public Lecture(string title, string description, DateTime date, string time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        Speaker = speaker;
        Capacity = capacity;
    }

    public override void DisplayStandardDetails()
    {
        base.DisplayStandardDetails();
        Console.WriteLine($"Speaker: {Speaker}\nCapacity: {Capacity}");
    }
}

class Reception : Event
{
    public string RsvpEmail { get; set; }

    public Reception(string title, string description, DateTime date, string time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        RsvpEmail = rsvpEmail;
    }

    public override void DisplayStandardDetails()
    {
        base.DisplayStandardDetails();
        Console.WriteLine($"RSVP Email: {RsvpEmail}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("456 Oak St", "Denver", "CO", "USA");

        Event lecture = new Lecture("Tech Lecture", "A talk about technology.", DateTime.Now, "10:00 AM", address, "Dr. Smith", 100);
        Event reception = new Reception("Networking Reception", "An event to meet new people.", DateTime.Now, "6:00 PM", address, "rsvp@event.com");

        lecture.DisplayStandardDetails();
        Console.WriteLine("\n-----------------\n");
        reception.DisplayStandardDetails();
    }
}
