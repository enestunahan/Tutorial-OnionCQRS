namespace Tutorial_OnionCQRS.Application.Parameters
{
    public class RequestParameter
    {
        public int PageSize { get; set; }
        public int PageNumber {get; set; }

        public RequestParameter(int pageSize , int pageNumber)
        {

        }
    }
}
