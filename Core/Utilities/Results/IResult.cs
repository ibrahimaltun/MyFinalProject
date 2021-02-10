using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    // Temel voidler için başlangıç
    public interface IResult
    {
        //bool : just true or false
        bool Success { get; } //get okumak, set yazmak için.
        string Message { get; } // Kullanıcıya dönecek mesaj true ise bu olsun false ise bu olsun.


    }
}
