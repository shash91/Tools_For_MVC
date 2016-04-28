using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EssentialTools.Models;
namespace EssentialTools.Models
{
    public interface IValueCalculator
    {
         decimal ValueProducts(IEnumerable<Product> products);
    }
}