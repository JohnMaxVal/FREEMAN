namespace EssentialTools.Models
{
    public interface IDiscountHepler
    {
        decimal ApplyDiscount(decimal totalParam);
    }

    public class DefaultDiscountHelper : IDiscountHepler
    {
        public decimal ApplyDiscount(decimal totalParam)
        {
            return (totalParam - (10m / 100m * totalParam));
        }
    }
}