interface INotificationService
{
    public string Recipient { get; set; }
    public string Message { get; set; }
    void SendNotification();
}