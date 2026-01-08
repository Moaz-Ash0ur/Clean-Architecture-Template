namespace CleanArchTemp.Infrastructure.Settings;

public class AppSettings
{  
    public string CorsPolicyName { get; set; } = default!;
    public string[] AllowedOrigins { get; set; } = default!;
}