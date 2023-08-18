using BotanLike.Application.Services.Common.UserCommon;
using BotanLike.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotanLike.Application.Services.Queries.UserQueries
{
    public class UserQueryService : IUserQueryService
    {
        private readonly IUserRepository _userRepository;
        public UserQueryService(IUserRepository repository)
        {
            _userRepository = repository;
        }
        public User GetUser(int id)
        {
            return _userRepository.GetUser(id);
        }

        //public User GetUserByEmail(string email)
        //{
        //    throw new NotImplementedException();
        //}

        //public User GetUserByLogin(string username)
        //{
        //    throw new NotImplementedException();
        //}

        //public User GetUserByPhone(string phone)
        //{
        //    throw new NotImplementedException();
        //}

        //public User GetUserByTariffType(TariffType tariffType)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
