namespace Tutorial_OnionCQRS.Application.Wrappers
{
    public class ServiceResponse <T> : BaseResponse
    {
        public T Value { get; set; }

        public ServiceResponse(T value)
        {
            this.Value = value;
        }
        public ServiceResponse()
        {

        }
    }
}
