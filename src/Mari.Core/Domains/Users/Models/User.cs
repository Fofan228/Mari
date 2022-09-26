using Mari.Core.Shared.AbstractClasses;

namespace Mari.Core.Domains.Users.Models;

public class User : ModelBase<Guid>
{
    public string Username { get; set; }
    public string Role { get; set; }
}