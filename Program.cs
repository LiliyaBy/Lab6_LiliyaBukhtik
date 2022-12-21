using System.Runtime.Intrinsics.Arm;

namespace Lab6_LiliyaBukhtik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PC  pc, pc3;

            Console.WriteLine("PC1:");
            pc = new PC(999999.9, "AbracadabraPC");
            pc.Print();
            Console.WriteLine("\nPC2:");

            RAM ram = new RAM("Kingston FURY Renegade DDR4 PC4-28800", "2x16GB");
            HDD hdd = new HDD("Samsung T7", "1TB", "external");
            pc3 = new PC(888888.9, "PCforGame",ram,hdd);
            pc3.Print();
        }
    }
}