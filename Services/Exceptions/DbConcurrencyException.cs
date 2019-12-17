using System;

namespace GPC.Services.Exceptions
{
    class DbConcurrencyException : ApplicationException
    {
        public DbConcurrencyException(string message) : base(message){
            
        }
    }
}