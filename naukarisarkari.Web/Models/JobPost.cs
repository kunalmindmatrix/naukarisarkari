public class JobPost
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Department { get; set; }
    public string State { get; set; }
    public string Qualification { get; set; }
    public string ApplyLink { get; set; }
    public string PdfLink { get; set; }
    public DateTime LastDateToApply { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
