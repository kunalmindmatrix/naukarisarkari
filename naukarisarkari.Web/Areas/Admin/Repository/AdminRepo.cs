using Microsoft.EntityFrameworkCore;

public class AdminRepo : IAdminRepo
{
    private readonly AppDbContext _context;

    public AdminRepo(AppDbContext context)
    {
        _context = context;
    }

    public async Task<AdminUser> ValidateAdminAsync(string username, string password)
    {
        return await _context.AdminUsers
            .FirstOrDefaultAsync(a => a.Username == username && a.Password == password);
    }
}
