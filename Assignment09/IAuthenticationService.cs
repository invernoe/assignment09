interface IAuthenticationService
{
    bool AuthenticateUser(string username, int password);
    bool AuthorizeUser(string username, string role);
}
