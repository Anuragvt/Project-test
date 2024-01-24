using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
   
    internal class Program
    {
        double acost = 0.35, bcost = 0.20, mcost = 0.50, lcost = 0.15;
        double totalCost = 0, MelonCost = 0, LimeCost = 0;

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a Apple quantity: ");
                int AppleQuantity = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter a Banana quantity: ");
                int BananaQuantity = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter a Melon quantity: ");
                int MelonQuantity = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter a Lime quantity: ");
                int LimeQuantity = Convert.ToInt32(Console.ReadLine());
                Program p = new Program();
                Double TCost = p.GetTotalCost(AppleQuantity, BananaQuantity, MelonQuantity, LimeQuantity);

                Console.WriteLine("TotalCost: " + TCost);
            } 
            catch(Exception ex) 
            {
                Console.WriteLine("Below error has occured, please try again \n" +"'" +ex.Message +"'");
            }
            Console.ReadLine();
        }

        public double GetTotalCost(int aquantity, int bquantity,int mquantity, int lquantity)
        {           

            int melonremainder = mquantity % 2;

            int melonquotient = mquantity / 2;

            MelonCost = mcost * melonquotient + mcost * melonremainder;

            int limeremainder = lquantity % 3;

            int limequotient = lquantity / 3;

            LimeCost = lcost * 2 * limequotient + lcost * limeremainder;

            totalCost = (acost * aquantity) + (bcost * bquantity) + MelonCost + LimeCost;
            return totalCost;
        }
    }
}
