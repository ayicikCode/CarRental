using Business.Concrete;
using DataAccess.Concrete.InMEmory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var c in carManager.GetAll())
            {
                if (c.UnitPrice < 4000)
                {
                    Console.WriteLine(c.ProductName + c.Details);
                }
                
            }
            
        }
    }
}
