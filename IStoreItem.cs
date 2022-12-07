using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Disks
{
    public interface IStoreItem
    {
        public double Price { get; set; }
        public void DiscountPrice(int percent)
        {
            Price -= (percent * Price) / 100;
        }
    }
}
