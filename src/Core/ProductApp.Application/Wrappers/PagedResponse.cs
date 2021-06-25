namespace ProductApp.Application.Wrappers
{
    public class PagedResponse<T> : ServiceResponse<T>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public PagedResponse(T value, int PageNumber = 1, int PageSize = 10) : base(value)
        {
            this.PageNumber = PageNumber;
            this.PageSize = PageSize;
        }
    }
}