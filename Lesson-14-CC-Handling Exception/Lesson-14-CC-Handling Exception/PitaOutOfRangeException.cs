using System;
using System.Runtime.Serialization;

namespace Lesson_14_CC_Handling_Exception
{
    [Serializable]
    internal class PitaOutOfRangeException : Exception
    {
        public PitaOutOfRangeException()
        {
        }

        public PitaOutOfRangeException(string message) : base(message)
        {
        }

        public PitaOutOfRangeException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected PitaOutOfRangeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}