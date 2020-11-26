using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AvailabilityAPI.Models;

namespace AvailabilityAPI.Repository
{
    public class BookRepo: IBookRepo
    {

        List<BookModel> Books = new List<BookModel>
        {
            new BookModel { Id=1 , Name = "Harry Potter and the Philosopher's Stone",Price = 300,Description="1st book of Harry Potter" },
            new BookModel { Id=2 , Name = "Harry Potter and the Chamber of secrets",Price = 349,Description="2nd book of Harry Potter" },
            new BookModel { Id=3 , Name = "Harry Potter and the Prisoner of Azkaban",Price = 301,Description="3rd book of Harry Potter" },
            new BookModel { Id=4 , Name = "Harry Potter and the Goblet of Fire",Price = 359,Description="4th book of Harry Potter" },
            new BookModel { Id=5 , Name = "Harry Potter and the Order of Phoenix",Price = 517,Description="5th book of Harry Potter" },
            new BookModel { Id=6 , Name = "Harry Potter and the Half Blood Prince",Price = 573,Description="6th book of Harry Potter" },
            new BookModel { Id=7 , Name = "Harry Potter and the Deathly Hallows",Price = 363,Description="7th book of Harry Potter" },
        };

        public List<BookModel> GetBookList()
        {
            return  Books;
        }

    }
}
