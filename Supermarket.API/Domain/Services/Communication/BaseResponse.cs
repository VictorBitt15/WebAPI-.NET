using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supermarket.API.Domain.Services.Communication
{
    public abstract class BaseResponse
    {
        public bool Sucess { get; set; }
        public string Message { get; set; }
        public BaseResponse(bool sucess, string message)
        {
            Sucess = sucess;
            Message = message;
        }
    }
}