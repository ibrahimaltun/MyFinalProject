using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    //SOLID prensipleri, Bu yapılan hareket O harfidir.
    //O : Open Closed Principle : Yazdığın koda yeni bir özellik ekliyorsan mevcuttaki hiç bir koda dokunamazsın.
    //Yani sonradan ekleyeceğin kodlar önceki kodları değiştirmeden olacak.
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetByUnitPrice(40,100))
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
