using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult //çıplak class kalmasın
    {
        //Burası bir constructor'dır;
        public Result(bool success, string message):this(success) //C# da this demek o class demektir.
        {
            Message = message; // Hani Message sadece get'di, set edilemiyordu ama burada ettik.
        }

        public Result(bool success)
        {
            Success = success;
        }

        // => dan sonrasını return olarak getirir.
        //public bool Success => throw new NotImplementedException(); //Bu bir yeni nesil implementasyon.
        //public string Message => throw new NotImplementedException();
        public bool Success { get; }
        public string Message { get; } //overdesign : aşırı tasarım ; bunun olmasını istemeyiz.
    }
}