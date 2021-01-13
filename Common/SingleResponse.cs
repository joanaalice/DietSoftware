using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public class SingleResponse<T> : Response
    {
        public T Data { get; set; } 
    }
}
