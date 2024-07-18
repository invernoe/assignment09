class SmsNotificationService : INotificationService
{
    public string Recipient { get; set; }
    public string Message { get; set; }

    public void SendNotification()
    {
        System.Console.WriteLine($"SMS message from {Recipient}:\n{Message}");
    }
}