using BotanLike.Application.Services.Common.Subscription;
using BotanLike.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotanLike.Application.Services.Commands.Subscription
{
    public interface ISubscriptionCommandService
    {
        bool UpgradeToStandart(int userId);
        bool UpgradeToBusiness(int userId);
        bool ExpiredSubscription(int userId);
    }
}
