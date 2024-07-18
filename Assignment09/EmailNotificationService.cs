class EmailNotificationService : INotificationService
{
    public string Recipient { get; set; }
    public string Message { get; set; }

    public void SendNotification()
    {
        System.Console.WriteLine($"Email from {Recipient}:\n{Message}");
    }
}