using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Concrete
{
    //public yaptığın zaman bu class'a diğer katmanların erişmesi sağlanır.
    //eğer public olmazsa diğer katmanlar buraya erişemez.
    //*****************************************************
    //Bir class'ın default değeri internal'dır.
    public class Product:IEntity
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }

    }
}
