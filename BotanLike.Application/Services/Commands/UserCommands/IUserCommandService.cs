using BotanLike.Domain.Entities;
using BotanLike.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotanLike.Application.Services.Commands.UserCommands
{
    public interface IUserCommandService
    {
        bool CreateNewUser(NewUserModel newUserModel);
    }
}
