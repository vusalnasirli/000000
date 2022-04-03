using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp300.MODELS
{
    class Exception
    {
        private string message;

        public Exception(string message)
        {
            this.message = message;
        }

        class NotAvailableException : Exception
        {
            public NotAvailableException() : base(" The room is not empty ")
            { }
            public NotAvailableException(string message) : base(message)
            { }
        }
    }
}
