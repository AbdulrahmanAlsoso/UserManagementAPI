using UserManagementAPI.Models;

namespace UserManagementAPI.Services;

public class UserService : IUserService
{
    private readonly List<User> _users = new();

    public IEnumerable<User> GetAllUsers() => _users;

    public User GetUserById(int id) => _users.FirstOrDefault(u => u.Id == id);

    public void AddUser(User user)
    {
        user.Id = _users.Count + 1;
        _users.Add(user);
    }

    public void UpdateUser(int id, User user)
    {
        var existingUser = GetUserById(id);
        if (existingUser == null) return;

        existingUser.Name = user.Name;
        existingUser.Email = user.Email;
    }

    public void DeleteUser(int id) => _users.RemoveAll(u => u.Id == id);
}
