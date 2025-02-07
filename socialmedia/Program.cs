using System;

public class Socialmedia
{
    public string Type()
    {
        Console.WriteLine("ENTER YOUR SOCIAL MEDIA PLATFORM:");
        string typ = Console.ReadLine();
        return typ;
    }

    public string ProfileName()
    {
        Console.WriteLine("ENTER YOUR USERID:");
        string id = Console.ReadLine();

        Console.WriteLine("ENTER YOUR PASSWORD:");
        string pass = Console.ReadLine();

        return $"UserID: {id}, Password: {pass}";
    }
}

public class Program
{
    public void Main()
    {
        Socialmedia obj1 = new Socialmedia();

        string platform = obj1.Type();
        string profileDetails = obj1.ProfileName();

        Console.WriteLine("\nYour Social Media Details:");
        Console.WriteLine($"Platform: {platform}");
        Console.WriteLine(profileDetails);
    }
}
