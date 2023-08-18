using BotanLike.Application.Services.Common.UserCommon;
using BotanLike.Domain.Entities;
using BotanLike.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BotanLike.Infrastructure.Persistance
{
    public class UserRepository : IUserRepository
    {
        private readonly BotanLikeDbContext _botanLikeDbContext;
        public UserRepository(BotanLikeDbContext context)
        {

            _botanLikeDbContext = context;

        }
        public User GetUser(int Id)
        {
            var user = _botanLikeDbContext.User.FirstOrDefault(u => u.Id == Id);
            return user;
        }

        public bool CreateNewUser(NewUserModel newUserModel)
        {
            try
            {
                var user = new User
                {
                    Login = newUserModel.Login,
                    PasswordHash = newUserModel.Password, 
                    Email = newUserModel.Email,
                    // Другие свойства, если нужно
                };

                _botanLikeDbContext.User.Add(user);
                _botanLikeDbContext.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                // Можно добавить логирование, если нужно
                // _logger.LogError(e, "Ошибка при создании нового пользователя");

                return false;
            }
        }

    }
}
