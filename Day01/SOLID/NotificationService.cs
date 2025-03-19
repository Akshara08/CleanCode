using System;
public class NotificationService
{
private INotificationChannel Notificationchannel;
private Imessage Message;

Public NotificationService(INotificationChannel notificationChannel, Imessage message)
{
NotificationChannel = notificationChannel;
Message = message;
}

public void SendNotification()
{
NotificationChannel.SendNotification(Message);
}
}





