using BotanLike.Domain.Entities;
using BotanLike.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotanLike.Application.Services.Common.UserCommon
{
    public interface IUserRepository
    {
        User GetUser(int id);
        //User GetUserByEmail(string email);
        //User GetUserByLogin(string username);
        //User GetUserByPhone(string phone);
        //User GetUserByTariffType(TariffType tariffType);
        bool CreateNewUser(NewUserModel newUserModel);

    }
}
