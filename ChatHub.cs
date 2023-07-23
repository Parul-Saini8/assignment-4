public async Task SendUserTyping(string user)
{
    await Clients.Others.SendAsync("UserTyping", user);
}

public async Task SendReceiveAnonMessage(string message)
{
    await Clients.All.SendAsync("ReceiveAnonMessage", message);
}
