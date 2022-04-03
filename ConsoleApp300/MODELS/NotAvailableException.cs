using System;
using System.Runtime.Serialization;

namespace ConsoleApp300.MODELS
{
    [Serializable]
    internal class NotAvailableException : Exception
    {
        public NotAvailableException()
        {
        }

        public NotAvailableException(string message) : base(message)
        {
        }

        public NotAvailableException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NotAvailableException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}