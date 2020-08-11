using System;

namespace GoodBooks.Data.Models
{
    public class TimeStampedItem
    {
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}