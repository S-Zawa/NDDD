using System;

namespace NDDD.Domain.Exceptions
{
    public sealed class FakeException : Exception
    {
        public FakeException(string message, Exception exception) : base(message, exception)
        {
        }
    }
}