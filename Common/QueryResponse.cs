using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public class QueryResponse<T>
    {
        public List<T> Data { get; set; }
    }
}
