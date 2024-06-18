internal class GiantKillerRobot
{
    public bool Active { get; private set; }
    public Intensity EyeLaserIntensity { get; set; }
    public List<Target> Targets { get; private set; }
    public int CurrentTarget { get; private set; }
    public bool IsAlive { get; private set; }

    public GiantKillerRobot()
    {
        Targets = new List<Target>();
    }

    public void Initialize()
    {
        Console.WriteLine("The robot is initializing.");
        Active = true;
        CurrentTarget = -1;
    }

    public void FireLaserAt(int targetIndex)
    {
        Console.WriteLine($"Firing laser at : {Targets[targetIndex]}");
        Console.WriteLine();
        IsAlive = false;
    }

    public void AcquireNextTarget()
    {
        CurrentTarget++;
        if (CurrentTarget < Targets.Count)
        {
            Console.WriteLine($"Acquiring target : {Targets[CurrentTarget]}");
            IsAlive = true;
        }
        else
        {
            Console.WriteLine($"No targets left");
            Active = false;
        }
    }
}
class Planet
{
    public string Name { get; set; } = " ";
    public bool ContainsLife { get; set; } = true;
}
enum Planets
{
    Earth,
    Mars,
    Saturn
}
enum Intensity
{
    Kill,
    Freeze
}
enum Target
{
    Animal,
    Human,
    Superhero
}

