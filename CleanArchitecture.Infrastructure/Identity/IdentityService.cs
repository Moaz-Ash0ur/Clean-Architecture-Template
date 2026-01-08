using CleanArchTemp.Application.Common.Interfaces;

namespace CleanArchitecture.Infrastructure.Identity
{
    public class IdentityService : IIdentityService
    {
        public Task<string?> GetUserNameAsync(string userId)
        {
            throw new NotImplementedException();
        }
    }
}
