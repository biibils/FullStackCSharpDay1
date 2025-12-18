namespace BookMVC.Models;

public class Books
{
		public int Id { get; set; }
		public required string Title { get; set; }
		public required string Author { get; set; }
		public required string Genre { get; set; }
		public required int YearPublished { get; set; }
}