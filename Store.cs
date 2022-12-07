using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Disks
{
    internal class Store
    {
        string storeName;
        string address;
        List<Audio> audios;
        List<DVD> dvds;

        public Store(string _storeName, string _address)
        {
            storeName = _storeName;
            address = _address;
            audios = new List<Audio>();
            dvds = new List<DVD>();
        }

        public static List<DVD> operator+ (Store a, DVD b)
        {
            a.dvds.Add(b);
            
            return a.dvds;
        }
        public static List<DVD> operator- (Store a,DVD b)
        {
            a.dvds.Remove(b);
            return a.dvds;
        }
        public static List<Audio> operator+ (Store a,Audio b)
        {  
            a.audios.Add(b);
            return a.audios;
        }
        public static List<Audio> operator -(Store a, Audio b)
        {
            a.audios.Remove(b);
            return a.audios;
        }

        public override string ToString()
        {
            return $"{string.Join(" ",dvds)}" + "\n" + $"{string.Join(" ",audios)}";
        }
    }
}
    