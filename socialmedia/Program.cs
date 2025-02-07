

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

        return $"UserID: {id} \nPassword: {pass}";
    }

    public string Like()
    {
        Console.WriteLine("ENTER THE POST YOU WANT TO LIKE:");
        string post = Console.ReadLine();
        return $"You liked the post: {post}";
    }

    public string Comment()
    {
        Console.WriteLine("ENTER YOUR COMMENT:");
        string comment = Console.ReadLine();
        return $"Your comment: {comment}";
    }

    public string Reels()
    {
        Console.WriteLine("ENTER REEL NAME YOU WANT TO WATCH:");
        string reel = Console.ReadLine();
        return $"You are watching: {reel}";
    }
}

public class Program
{
    public static void Main()
    {
        Socialmedia obj1 = new Socialmedia();
       
        string platform = obj1.Type();
        
        string profileDetails = obj1.ProfileName();
        
        string like = obj1.Like();
        
        string comment = obj1.Comment();
        
        string reels = obj1.Reels();
        
        Console.WriteLine("\nYour Social Media Details:");
        Console.WriteLine($"Platform: {platform}");
        Console.WriteLine(profileDetails);
        Console.WriteLine(like);
        Console.WriteLine(comment);
        Console.WriteLine(reels);
    }
}
