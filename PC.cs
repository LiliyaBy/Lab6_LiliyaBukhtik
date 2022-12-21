using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_LiliyaBukhtik
{
    internal class PC 
    {
        private double price=9860342.4;
        private string model="PC 364317431";
        RAM ram = new RAM();
        HDD hdd = new HDD();
               
        public PC()
        {

        }
        public PC(double price,string model)
        {
            this.price = price;
            this.model = model;
            ram = new RAM();
            hdd = new HDD();
        }
        public PC(double price, string model, RAM ram, HDD hdd)
        {
            this.price = price;
            this.model = model;
            this.ram = ram;
            this.hdd = hdd;
           
        }

        public void Print() 
        {
            Console.WriteLine($"Price: {price}");
            Console.WriteLine($"Model: {model}");
            ram.Print();
            hdd.Print();
        }
    }

    class RAM 
    {
        public string title= "HP 32GB DDR4 PC4-25600 P07646-B21";
        public string volume= "32 GB";
        public RAM()
        {

        }
        public RAM(string title, string volume)
        {
            this.title = title;
            this.volume = volume;
        }

        public void Print()
        {
            Console.WriteLine($"Model RAM: {title}");
            Console.WriteLine($"Volume RAM: {volume}");

        }
    }
    class HDD 
    {
        public string title = "WD Blue 2TB WD20EZBX";
        public string volume = "2TB";
        public string type = "interior";
        public HDD()
        {

        }
        public HDD(string title, string volume, string type)
        {
            this.title = title;
            this.volume = volume;
            this.type = type;
        }

        public void Print()
        {
            Console.WriteLine($"Model HDD: {title}");
            Console.WriteLine($"Volume HDD: {volume}");
            Console.WriteLine($"Type: {type}");

        }
    }

}
