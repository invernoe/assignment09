class SeriesByTwo : IMySeries
{
    public int Current { get; set; }

    public void GetNext()
    {
        Current += 2;
    }

    public void Reset()
    {
        Current = 0;
    }
}