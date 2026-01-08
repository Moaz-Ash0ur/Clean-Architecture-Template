using CleanArchTemp.Domain.Common.Results;

namespace CleanArchTemp.Application.Common.Interfaces;

public interface IIdentityService
{
    Task<string?> GetUserNameAsync(string userId);
}

public interface IUser
{
    string? Id { get; }
}