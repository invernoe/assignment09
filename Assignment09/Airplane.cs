class Airplane : IMoveable, IFlyable
{
    void IMoveable.Backward()
    {
        System.Console.WriteLine("Move backward");
    }

    void IFlyable.Backward()
    {
        System.Console.WriteLine("Fly backward");
    }

    void IMoveable.Forward()
    {
        System.Console.WriteLine("Move forward");
    }

    void IFlyable.Forward()
    {
        System.Console.WriteLine("Fly forward");
    }
}