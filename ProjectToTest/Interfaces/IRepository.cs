using ProjectToTest.Models;
using System.Collections.Generic;

namespace ProjectToTest.Interfaces
{
    public interface IRepository
    {
        IEnumerable<User> GetAll();
        User Create(User user);
        void Get(int id);
    }
}
