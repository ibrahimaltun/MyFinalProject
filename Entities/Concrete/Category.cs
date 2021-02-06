using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;


namespace Entities.Concrete
{
    //Çıplak Class Kalmasın
    //Çıplak Class : Bir class inheritance falan almıyorsa ilerde sıkıntı çıkartır.
    public class Category:IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}
