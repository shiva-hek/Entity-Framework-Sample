using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repository.Exceptions
{
    public class FailedToFindBookByIdException :Exception
    {
        private int id;

        public FailedToFindBookByIdException()
        {
        }

        public FailedToFindBookByIdException(string message, int id) : this(message)
        {
            this.id = id;
        }

        public FailedToFindBookByIdException(string? message) : base(message)
        {
        }

        public FailedToFindBookByIdException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected FailedToFindBookByIdException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
