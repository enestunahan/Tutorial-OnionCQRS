namespace Tutorial_OnionCQRS.Application.Exceptions
{
    public class ValidationException : Exception
    {
        public ValidationException(string message) : base(message)
        {

        }

        public ValidationException(Exception ex) : this(ex.Message) 
        {

        }

        public ValidationException() : this("Validation error occured")
        {

        }
    }
}
