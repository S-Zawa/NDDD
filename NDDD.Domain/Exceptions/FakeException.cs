using System;

namespace NDDD.Domain.Exceptions
{
    public sealed class FakeException : ExceptionBase
    {
        public FakeException(string message, Exception exception) : base(message, exception)
        {
        }
        public override ExceptionKind Kind => ExceptionKind.Error;
    }
}