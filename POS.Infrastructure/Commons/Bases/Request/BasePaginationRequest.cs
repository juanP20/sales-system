namespace POS.Infrastructure.Commons.Bases.Request
{
    public class BasePaginationRequest
    {
        public int NumPage { get; set; } = 1;
        public int NumRecordsPage { get; set; } = 10;

        private readonly int NumMaxRcordsPage = 50;
        public string Order { get; set; } = "asc";
        public string? sort { get; set; } = null;
        public int Records
        {
            get => NumRecordsPage;
            set
            {
                NumRecordsPage = value > NumMaxRcordsPage ? NumMaxRcordsPage : value;
            }
        }
    }
}
