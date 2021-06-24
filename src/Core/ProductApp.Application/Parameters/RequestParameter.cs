namespace ProductApp.Application.Parameters
{
    public class RequestParameter
    {
        public RequestParameter(int PageSize, int PageNumber)
        {
            this.PageSize = PageSize;
            this.PageNumber = PageNumber;
        }
        public int PageSize { get; set; }
        public int PageNumber { get; set; }
    }
}
