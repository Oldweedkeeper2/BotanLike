using BotanLike.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotanLike.Application.Services.Queries.UserQueries
{
    public interface IUserQueryService
    {
        User GetUser(int id);
        //User GetUserByEmail(string email);
        //User GetUserByLogin(string username);
        //User GetUserByPhone(string phone);
        //User GetUserByTariffType(TariffType tariffType);
    }
}
