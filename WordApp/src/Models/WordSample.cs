namespace WordApp.Models
{
    public class WordSample
    {
        public int WordSampleId { get; set; }
        public int WordID { get; set; }
        public string Samples { get; set; }
        public Word Word { get; set; }
    }
}
