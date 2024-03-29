﻿using System;

namespace BLL.Exceptions
{
    public class EntityAlreadyExistsException : Exception
    {
        public EntityAlreadyExistsException() { }
        public EntityAlreadyExistsException(string message) : base(message) { }
        public EntityAlreadyExistsException(string message, Exception innerException) : base(message, innerException)
        { }

        public EntityAlreadyExistsException(string name, object key)
            : base($"Entity \"{name}\" ({key}) already exists.")
        {
        }
    }
}
