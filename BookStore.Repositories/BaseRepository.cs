using BookStore.Models.Models;
using BookStore.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Repositories
{
   public class BaseRepository
    {
        protected readonly BookstoreContext _context = new BookstoreContext();
    }
}
