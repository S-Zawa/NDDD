using System;

namespace NDDD.Domain.Exceptions
{
    public abstract class ExceptionBase : Exception
    {
        public ExceptionBase(string message) : base(message)
        {
        }

        public ExceptionBase(string message, Exception exception) : base(message, exception)
        {
        }

        public abstract ExceptionKind Kind { get; }

        public enum ExceptionKind
        {
            Info,
            Warning,
            Error
        }
    }
}