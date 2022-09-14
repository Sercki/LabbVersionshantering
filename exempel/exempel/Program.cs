Duck Anka = new Duck();
Anka.run();

class Duck
{
    int legs = 2;
    int wings = 2;
    string identity = "bird";

    public void fly()
    {
        Console.WriteLine($"I'm using {wings} wings to fly.");
    }
    public void walk()
    {
        Console.WriteLine($"I'm using {legs} wings to walk.");
    }
    public void swim()
    {
        Console.WriteLine($"I'm using {legs} legs to swim.");
    }
    public void identification()
    {
        Console.WriteLine($"I'm a {identity}.");
    }
    public void run()
    {
        identification();
        fly();
        walk();
        swim();
    }
}
