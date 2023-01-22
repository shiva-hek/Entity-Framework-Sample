using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repository.Exceptions
{
    [Serializable]
    public class FailedToFindEntityByIdException : Exception
    {
        private int id;

        public FailedToFindEntityByIdException()
        {
        }

        public FailedToFindEntityByIdException(string message, int id) : this(message)
        {
            this.id = id;
        }

        public FailedToFindEntityByIdException(string? message) : base(message)
        {
        }

        public FailedToFindEntityByIdException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected FailedToFindEntityByIdException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
