using BotanLike.Application.Services.Common.Subscription;
using BotanLike.Application.Services.Common.UserCommon;
using BotanLike.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotanLike.Application.Services.Commands.Subscription
{
    public class SubscriptionCommandService : ISubscriptionCommandService
    {
        private readonly ISubscriptionRepository _subscriptionRepository;
        public SubscriptionCommandService(ISubscriptionRepository repository)
        {
            _subscriptionRepository = repository;

        }

        public bool ExpiredSubscription(int userId)
        {
            return _subscriptionRepository.ExpiredSubscription(userId);
        }

        public bool UpgradeToBusiness(int userId)
        {
            return _subscriptionRepository.UpgradeToBusiness(userId);
        }

        public bool UpgradeToStandart(int userId)
        {
            return _subscriptionRepository.UpgradeToStandart(userId);
        }
    }
}
