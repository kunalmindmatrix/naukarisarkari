public interface IAdminRepo
{
    Task<AdminUser> ValidateAdminAsync(string username, string password);
}
