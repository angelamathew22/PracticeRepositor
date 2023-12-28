using System;
namespace Assignment4
{


    class Furniture
    {
        public int OrderId { get; set; }
        public string OrderDate { get; set; }
        public string FurnitureType { get; set; }
        public int Qty { get; set; }
        public double TotalAmt { get; set; }
        public string PaymentMode { get; set; }

        public void GetData()
        {
            Console.Write("Enter Order ID: ");
            OrderId = int.Parse(Console.ReadLine());

            Console.Write("Enter Order Date: ");
            OrderDate = Console.ReadLine();

            Console.Write("Enter Furniture Type (Chair/Cot): ");
            FurnitureType = Console.ReadLine();

            Console.Write("Enter Quantity: ");
            Qty = int.Parse(Console.ReadLine());

            Console.Write("Enter Total Amount: ");
            TotalAmt = double.Parse(Console.ReadLine());

            Console.Write("Enter Payment Mode (credit/debit card): ");
            PaymentMode = Console.ReadLine();
        }

        public void ShowData()
        {
            Console.WriteLine($"Order ID: {OrderId}");
            Console.WriteLine($"Order Date: {OrderDate}");
            Console.WriteLine($"Furniture Type: {FurnitureType}");
            Console.WriteLine($"Quantity: {Qty}");
            Console.WriteLine($"Total Amount: {TotalAmt}");
            Console.WriteLine($"Payment Mode: {PaymentMode}");
        }
    }

    class Chair : Furniture
    {
        public string ChairType { get; set; }
        public string Purpose { get; set; }
        public double Rate { get; set; }

        public new void GetData()
        {
            base.GetData();

            Console.Write("Enter Chair Type (Wood/Steel/Plastic): ");
            ChairType = Console.ReadLine();

            Console.Write("Enter Purpose (Home/Office): ");
            Purpose = Console.ReadLine();

            Console.Write("Enter Rate: ");
            Rate = double.Parse(Console.ReadLine());
        }

        public new void ShowData()
        {
            base.ShowData();
            Console.WriteLine($"Chair Type: {ChairType}");
            Console.WriteLine($"Purpose: {Purpose}");
            Console.WriteLine($"Rate: {Rate}");
        }
    }

    class WoodChair : Chair
    {
        public string WoodType { get; set; }

        public new void GetData()
        {
            base.GetData();

            Console.Write("Enter Wood Type (Teak Wood/Rose Wood): ");
            WoodType = Console.ReadLine();
        }

        public new void ShowData()
        {
            base.ShowData();
            Console.WriteLine($"Wood Type: {WoodType}");
        }
    }

    class SteelChair : Chair
    {
        public new void GetData()
        {
            base.GetData();
        }

        public new void ShowData()
        {
            base.ShowData();
        }
    }

    class Program
    {
        static void Main()
        {
            WoodChair woodChair = new WoodChair();
            woodChair.GetData();
            Console.WriteLine("\nDetails of Wood Chair:");
            woodChair.ShowData();

            Console.WriteLine("\n---------------------------\n");

            SteelChair steelChair = new SteelChair();
            steelChair.GetData();
            Console.WriteLine("\nDetails of Steel Chair:");
            steelChair.ShowData();
        }
    }
}
