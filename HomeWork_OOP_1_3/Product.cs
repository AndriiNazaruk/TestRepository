using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_OOP_1_2
{
    [Serializable]
    public class Product
    {
        public Product()
        {

        }
        public Product(string _NameOfProduct, DateTime _PurchaseDate, int _StockBalance, double _PurchasePrice)
        {
            NameOfProduct = _NameOfProduct;
            PurchasePrice = _PurchasePrice;
            PurchaseDate = _PurchaseDate;
            StockBalance = _StockBalance;
        }
        public string NameOfProduct { get; set; }
        //закупочна ціна
        public double PurchasePrice { get; set; }
        //дата закупки
        public DateTime PurchaseDate { get; set; }
        public int StockBalance { get; set; }
        // //this function input and output data to(from) console
        public virtual void ConsoleInputAndOutPut()
        {
            try
            {
                Console.WriteLine("Enter Product Name (String)");
                NameOfProduct = Console.ReadLine();
                

                Console.WriteLine("Enter Purchase Price (Double) ");
                string PurchasePrice = Console.ReadLine();
                if (double.TryParse(PurchasePrice, out double _purchasePrice))
                {
                    Console.WriteLine($"Purchase price parsed , Purchase Price = {PurchasePrice}");
                    this.PurchasePrice = _purchasePrice;
                }
                else
                    Console.WriteLine($"You enter a wrong value");


                Console.WriteLine("Enter Purchase Date (DateTime like '2010.1.6') ");
                string PurchaseDate = Console.ReadLine();
                if (DateTime.TryParse(PurchaseDate, out DateTime _purchaseDate))
                {
                    Console.WriteLine($"Purchase Date parsed , Purchase Date : {PurchaseDate}");
                    this.PurchaseDate = _purchaseDate;
                }
                else
                    Console.WriteLine($"You input a wrong format");


                Console.WriteLine("Enter Stock Balance (int)");
                string StockBalance = Console.ReadLine();
                if(int.TryParse(StockBalance,out int _stockbalance))
                {
                    Console.WriteLine($"Stock Balance parsed , Stock Balance = {StockBalance}");
                    this.StockBalance = _stockbalance;
                }

                Console.WriteLine($"Name Of Product : {this.NameOfProduct}");
                Console.WriteLine($"Purchase Price : {this.PurchasePrice}");
                Console.WriteLine($"Purchase Date : {this.PurchaseDate}");
                Console.WriteLine($"Stock Balance : {this.StockBalance}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public virtual void Print(List<Product> products)
        {
            foreach (var p in products)
            {
                Console.WriteLine($"NameOfProduct : {p.NameOfProduct}");
                Console.WriteLine($"PurchasePrice : {p.PurchasePrice}");
                Console.WriteLine($"PurchaseDate : {p.PurchaseDate}");
                Console.WriteLine($"StockBalance : {p.StockBalance}");
            }

        }
    }
}
