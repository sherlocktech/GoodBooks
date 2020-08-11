namespace GoodBooks.Data.Models
{
    public class Book : TimeStampedItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
    }
}
