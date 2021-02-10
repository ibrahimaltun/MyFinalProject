using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IDataResult<T>:IResult //Buradaki T yapısı Generic yapıdır. IMPORTANT
    {                   //Generic yapı kullanıcının dışarıdan gireceği veri tipidir. class,int vb.
        T Data { get; } //T tipinde Data adında bir 
    }
}
