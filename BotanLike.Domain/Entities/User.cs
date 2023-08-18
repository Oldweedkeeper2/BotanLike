namespace BotanLike.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; }
        public string Login { get; set; }
        public string PasswordHash { get; set; }
        public string? Phone { get; set; }
        public bool EmailConfirmed { get; set; } = false;
        public decimal Balance { get; set; } = decimal.Zero;
        public DateTime Created { get; set; } = DateTime.Now.ToUniversalTime();
        public TariffType Tariff { get; set; } = TariffType.Standard;
        public DateTime? SubscriptionStart { get; set; } = DateTime.Now.ToUniversalTime();
        public DateTime? SubscriptionEnd { get; set; } = DateTime.Now.AddMonths(1).ToUniversalTime();
    }
}
