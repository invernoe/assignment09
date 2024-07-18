class SeriesByThree : IMySeries
{
    public int Current { get; set; }

    public void GetNext()
    {
        Current += 3;
    }

    public void Reset()
    {
        Current = 0;
    }
}