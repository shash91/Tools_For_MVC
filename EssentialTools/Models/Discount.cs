using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EssentialTools.Models
{
    public interface IDiscountHelper
    {
        decimal ApplyDiscount(decimal totalParam);
    }
    public class Discount : IDiscountHelper
    {
        public decimal Discountsize;

        public Discount(decimal discountParam)
        {
            Discountsize = discountParam;
        }
        public decimal ApplyDiscount(decimal totalParam)
        {
            return (totalParam - (Discountsize / 100m * totalParam));
        }
    }
}