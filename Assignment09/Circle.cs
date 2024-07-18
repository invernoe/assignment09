class Circle : ICircle
{
    public double Radius { get; set; }
    public double Area { get; set; }

    public void DisplayShapeInfo()
    {
        System.Console.WriteLine($"Radius: {Radius}, Area = {Area}");
    }
}