namespace WebAPI_2.Seeds;

public static class DbInitializer
{
    public static void Initialize(ApplicationDbContext context)
    {
        context.Database.EnsureCreated();
        
        UserSeed.SeedUsers(context);

        context.SaveChanges();
    }
}
