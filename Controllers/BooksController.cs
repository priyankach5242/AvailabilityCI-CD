using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AvailabilityAPI.Models;
using AvailabilityAPI.Repository; 

namespace AvailabilityAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        public readonly IBookRepo BookRep;
        public BooksController(IBookRepo Book)
        {
            this.BookRep = Book;
        }
        [HttpGet]
        [Route("GetList")]
        public List<BookModel> GetList()
        {
            //_log4net.Info("API initiated to Get Book list");
            List<BookModel>  listOfBooks = BookRep.GetBookList();
            //if (listOfBooks == null)
            {
                //ModelState.AddModelError("", "No Books found");
                //return NotFound();
                //return new StatusCodeResult(400);
            }
            //_log4net.Info("No of Books retrieved : " + listOfBooks.Count());
            return listOfBooks;
            //return new StatusCodeResult(200);
            //return Ok();

        }
    }
}
