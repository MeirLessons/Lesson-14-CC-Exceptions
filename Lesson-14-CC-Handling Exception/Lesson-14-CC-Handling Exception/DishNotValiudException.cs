using System;
using System.Runtime.Serialization;

namespace Lesson_14_CC_Handling_Exception
{
    [Serializable]
    internal class DishNotValidException : Exception
    {
        public DishNotValidException()
        {
        }

        public DishNotValidException(string message) : base(message)
        {
        }

        public DishNotValidException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DishNotValidException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}