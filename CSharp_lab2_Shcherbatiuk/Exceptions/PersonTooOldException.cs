using System;

namespace CSharp_lab2_Shcherbatiuk.Exceptions
{
    internal class PersonTooOldException: ArgumentException
    {
        public PersonTooOldException(string message) : base(message) { }
    }
}
