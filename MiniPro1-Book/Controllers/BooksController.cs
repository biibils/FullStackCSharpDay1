using Microsoft.AspNetCore.Mvc;
using BookMVC.Models;

namespace BookMVC.Controllers;

public class BooksController : Controller
{
	private List<Books> books = new List<Books>
	{
		new Books { Id = 1, Title = "Leaders Eat Last", Author = "Simon Sinek", Genre = "Business", YearPublished = 2014 },
		new Books { Id = 2, Title = "Digital Minimalism", Author = "Cal Newport", Genre = "Self-Help", YearPublished = 2019 },
		new Books { Id = 3, Title = "Atomic Habits", Author = "James Clear", Genre = "Self-Help", YearPublished = 2018 },
		new Books { Id = 4, Title = "The Lean Startup", Author = "Eric Ries", Genre = "Business", YearPublished = 2011 },
		new Books { Id = 5, Title = "Rework", Author = "David Heinemeier Hansson", Genre = "Business", YearPublished = 2010 }
	};

	public IActionResult Index()
	{
		return View(books);
	}

	public IActionResult Detail(int id)
	{
		var book = books.FirstOrDefault(x => x.Id == id);
		return View(book);
	}
}

