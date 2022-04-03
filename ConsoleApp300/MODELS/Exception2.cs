using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp300.MODELS
{
    class Exception2
    {
        class NotFoundException : Exception
        {
            public NotFoundException() : base(" The room not found ")
            { }
            public NotFoundException(string message) : base(message)
            { }
        }
    }
}
