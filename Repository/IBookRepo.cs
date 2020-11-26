using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AvailabilityAPI.Models;

namespace AvailabilityAPI.Repository
{
    public interface IBookRepo
    {
        public List<BookModel> GetBookList();
    }
}
