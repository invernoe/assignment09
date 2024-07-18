interface IMySeries
{
    public static int Num = 0;
    public int Current { get; set; }

    public void GetNext();
    public void Reset();

    public static void ALoana() {
        System.Console.WriteLine("alo");
    }
}