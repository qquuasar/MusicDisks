using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Disks
{
    internal class DVD : Disk
    {
        string producer;
        string filmCompany;
        int minutesCount;

        public DVD(string _producer, string _filmCompany, int _minutesCount, string _name, string _genre) : base(_name, _genre)
        {
            producer = _producer;
            filmCompany = _filmCompany;
            minutesCount = _minutesCount;
            name = _name;
            genre = _genre;
        }
        public override int DiskSize { get { return (minutesCount / 64) * 2; } set => base.DiskSize = value; }

        public override void Burn(params string[] values)
        {
            producer = values[0];
            filmCompany = values[1];
            burnCount++;
            
        }
        public override string ToString()
        {
            return $"{name}, {genre}, {producer}, {filmCompany}, {minutesCount}, {burnCount}";
        }
    }
}
