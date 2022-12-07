using System;
using System.Security.Cryptography.X509Certificates;

namespace Music_Disks;

class Program
{
    static void Main()
    {
        Store store = new Store("Магазин Центрифуга", "Улица Пушкина");
        Audio trek1 = new Audio("анимешка 1", "некостудио", 25, "няшки", "jpop");
        Audio trek2 = new Audio("анимешка 2", "лолистудио", 10, "лоликон", "jpop");
        DVD disk1 = new DVD("Блекбибас", "Райан Гослинг", 185, "Драйв", "Боевик");
        DVD disk2 = new DVD("Блекадун", "Гослинг Райан", 322, "Бегущий по лезвию", "Фантастика");
        List<Audio> audioList = new List<Audio>();
        List<DVD> diskList = new List<DVD>();
        audioList = store + trek1;
        audioList = store + trek2;
        diskList = store + disk1;
        diskList = store + disk2;
        
        Console.WriteLine(store.ToString());
        trek1.Burn("анимешка 3", "анистудио");
        List<Disk> disks = new List<Disk>();
        disks.Add(trek1);
        disks.Add(trek2);
        disks.Add(disk1);
        disks.Add(disk2);
        foreach (Disk disk in disks)
        {
            Console.WriteLine($"Название: {disk.name}, размер: {disk.DiskSize}");
        }

    }
}