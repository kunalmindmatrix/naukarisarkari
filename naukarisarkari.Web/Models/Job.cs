namespace naukarisarkari.Web.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Department { get; set; }
        public DateTime PostedOn { get; set; }
        public string ApplyLink { get; set; }
    }
}
