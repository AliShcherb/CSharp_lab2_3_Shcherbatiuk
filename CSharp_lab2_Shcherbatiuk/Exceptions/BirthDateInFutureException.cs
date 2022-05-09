using System;

namespace CSharp_lab2_Shcherbatiuk.Exceptions
{
    internal class BirthDateInFutureException: ArgumentException
    {
        public BirthDateInFutureException(string message) : base(message) { }
    }
}
