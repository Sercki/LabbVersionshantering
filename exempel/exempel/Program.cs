Duck Anka = new Duck(2, 2, "bird");
Duck Hund = new Dog(4, 0, "dog");
Duck Fisk = new Fish(0, 0, 6, "fish");
Anka.run();
Console.WriteLine("");
Hund.run();
Console.WriteLine("");
Fisk.run();

class Duck
{
    protected int legs;           
    protected int wings;          
    protected string identity;    

    public Duck(int l, int w, string i)
    {
        this.legs = l;
        this.wings = w;
        this.identity = i;
    }
    public virtual void fly()
    {
        Console.WriteLine($"I'm using {wings} wings to fly.");
    }
    public virtual void walk()
    {
        Console.WriteLine($"I'm using {legs} legs to walk.");
    }
    public virtual void swim()
    {
        Console.WriteLine($"I'm using {legs} legs to swim.");
    }
    public virtual void identification()
    {
        Console.WriteLine($"I'm a {identity}.");
    }
    public virtual void run()
    {
        identification();
        fly();
        walk();
        swim();
    }
}

class Dog : Duck
{
    public Dog(int l, int w, string i) : base(l, w, i)
    {
    }

    public override void fly()
    {
        Console.WriteLine($"I cannot fly because I have {wings} wings.");
    }
}

class Fish : Duck
{
    int fins;
    public Fish(int l, int w, int f, string i) : base(l, w, i)
    {
        this.fins = f;
    }
    public override void fly()
    {
        Console.WriteLine($"I cannot fly because I have {wings} wings.");
    }
    public override void walk()
    {
        Console.WriteLine($"I cannot walk because I have {legs} legs.");
    }
    public override void swim()
    {
        Console.WriteLine($"I can swim because I have {fins} fins.");
    }

}