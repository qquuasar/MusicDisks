using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Disks
{
    internal class Audio : Disk
    {
        string artist;
        string recordingStudio;
        int songsNumber;
        public Audio(string _artist, string _recordingStudio, int _songsNumber, string _name, string _genre) : base(_name, _genre)
        {
            artist = _artist;
            recordingStudio = _recordingStudio;
            songsNumber = _songsNumber;
            name = _name;
            genre = _genre;
        }

        public override int DiskSize { get { return songsNumber * 8; } set => base.DiskSize = value; }
        public override void Burn(params string[] values)
        {
            artist = values[0];
            recordingStudio = values[1];
            burnCount++;
            
        }
        public override string ToString()
        {
            return $"{name}, {genre}, {artist}, {recordingStudio}, {songsNumber}, {burnCount}";
        }



    }
}
