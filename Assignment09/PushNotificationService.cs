class PushNotificationService : INotificationService
{
    public string Recipient { get; set; }
    public string Message { get; set; }

    public void SendNotification()
    {
        System.Console.WriteLine($"Push notification message from {Recipient}:\n{Message}");
    }
}