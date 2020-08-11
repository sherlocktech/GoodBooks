namespace GoodBooks.Data.Models
{
    public class BookReview : TimeStampedItem
    {
        public int Id { get; set; }
        public string ReviewAuthor { get; set; }
        public string ReviewContent { get; set; }

        public Book Book { get; set; }
    }
}
