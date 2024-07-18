class BasicAuthenticationService : IAuthenticationService
{
    private string[] userNames = { "Mahmoud", "Khaled", "Ahmed" };
    private int[] passwords = { 123, 456, 789 };
    private string[] roles = { "Admin", "User", "User" };

    public bool AuthenticateUser(string username, int password)
    {
        for (int i = 0; i < userNames.Length; i++)
        {
            if (userNames[i] == username && passwords[i] == password)
            {
                return true;
            }
        }
        return false;
    }

    public bool AuthorizeUser(string username, string role)
    {
        for (int i = 0; i < userNames.Length; i++)
        {
            if (userNames[i] == username && roles[i] == role)
            {
                return true;
            }
        }
        return false;
    }
}