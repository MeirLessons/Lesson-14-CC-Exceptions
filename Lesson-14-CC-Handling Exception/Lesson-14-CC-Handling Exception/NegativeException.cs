using System;
using System.Runtime.Serialization;

namespace Lesson_14_CC_Handling_Exception
{
    [Serializable]
    internal class NegativeException : ApplicationException
    {
        public string Name { get; set; }
        public NegativeException()
        {
        }

        public NegativeException(string message) : base(message)
        {
        }

        public NegativeException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NegativeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}