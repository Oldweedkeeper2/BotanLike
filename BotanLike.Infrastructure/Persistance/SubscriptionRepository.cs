using BotanLike.Application.Services.Common.Subscription;
using BotanLike.Application.Services.Common.UserCommon;
using BotanLike.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BotanLike.Infrastructure.Persistance
{
    public class SubscriptionRepository : ISubscriptionRepository
    {
        private readonly BotanLikeDbContext _botanLikeDbContext;

        public SubscriptionRepository(BotanLikeDbContext context)
        {
            _botanLikeDbContext = context;
        }
        public bool ExpiredSubscription(int userId)
        {
            try
            {
                var user = _botanLikeDbContext.User.FirstOrDefault(u => u.Id == userId);
                if (user == null)
                {
                    // Логирование исключения добавить, если нужно будет
                    return false;
                }

                user.Tariff = TariffType.None;
                user.SubscriptionStart = DateTime.Now;
                user.SubscriptionEnd = DateTime.Now.AddMonths(1);

                _botanLikeDbContext.Update(user);
                _botanLikeDbContext.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                // Логирование исключения добавить, если нужно будет
                return false;
            }
        }

        public bool UpgradeToBusiness(int userId)
        {
            try
            {
                var user = _botanLikeDbContext.User.FirstOrDefault(u => u.Id == userId);
                if (user == null)
                {
                    // Логирование исключения добавить, если нужно будет
                    return false;
                }

                user.Tariff = TariffType.Business;
                user.SubscriptionStart = DateTime.Now;
                user.SubscriptionEnd = DateTime.Now.AddMonths(1);

                _botanLikeDbContext.Update(user);
                _botanLikeDbContext.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                // Логирование исключения добавить, если нужно будет
                return false;
            }
        }

        public bool UpgradeToStandart(int userId)
        {
            try
            {
                var user = _botanLikeDbContext.User.FirstOrDefault(u => u.Id == userId);
                if (user == null)
                {
                    // Логирование исключения добавить, если нужно будет
                    return false;
                }

                user.Tariff = TariffType.Standard;
                user.SubscriptionStart = DateTime.Now;
                user.SubscriptionEnd = DateTime.Now.AddMonths(1);

                _botanLikeDbContext.Update(user);
                _botanLikeDbContext.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                // Логирование исключения добавить, если нужно будет
                return false;
            }
        }

    }
}
