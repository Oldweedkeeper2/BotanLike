using BotanLike.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotanLike.Application.Services.Common.Subscription
{
    public interface ISubscriptionRepository
    {
        bool UpgradeToStandart(int userId);
        bool UpgradeToBusiness(int userId);
        bool ExpiredSubscription(int userId);
    }
}
