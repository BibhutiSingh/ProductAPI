using System;


namespace ProductAPI.Core.Exceptions
{
    public class ModelValidationException: Exception
    {
        
        public ModelValidationException(string message, Exception? exception = null) : base(message, exception)
        {

        }
    }
}
