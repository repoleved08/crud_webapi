using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice_Two.ResponseDTO
{
    public class EmsSuccess
    {
        public int Code { get; set; }
        public string Message { get; set; }=string.Empty;

        public EmsSuccess(int code, string message)
        {
            Code = code;
            Message = message;
        }
    }
}
