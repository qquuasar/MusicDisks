using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Disks
{
    internal class Disk : IStoreItem
    {
        public string name;
        public string genre;
        public int burnCount;

        public Disk(string _name, string _genre)
        {
            name = _name;
            genre = _genre;

        }
        public virtual int DiskSize {get; set;}
        public virtual void Burn(params string[] values) { }
        public double Price { get; set; }
        public void DiscountPrice(int percent)
        {
            Price -= (percent * Price) / 100;
        }
    }
}
