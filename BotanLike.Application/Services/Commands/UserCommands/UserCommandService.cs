using BotanLike.Application.Services.Common.UserCommon;
using BotanLike.Domain.Entities;
using BotanLike.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotanLike.Application.Services.Commands.UserCommands
{
    public class UserCommandService : IUserCommandService
    {
        private readonly IUserRepository _userRepository;
        public UserCommandService(IUserRepository repository)
        {
            _userRepository = repository;
        }
        public bool CreateNewUser(NewUserModel newUserModel)
        {
            return _userRepository.CreateNewUser(newUserModel);
        }
    }
}
