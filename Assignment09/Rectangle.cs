class Rectangle : IRectangle
{
    public double Height { get; set; }
    public double Width { get; set; }
    public double Area { get; set; }

    public void DisplayShapeInfo()
    {
        System.Console.WriteLine($"Height: {Height}, Width = {Width}, Area = {Area}");
    }
}