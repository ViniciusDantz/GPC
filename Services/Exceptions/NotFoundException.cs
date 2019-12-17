using System;

namespace GPC.Services.Exceptions
{
    class NotFoundException : ApplicationException
    {
        public NotFoundException(string message) : base(message){
            
        }
    }
}