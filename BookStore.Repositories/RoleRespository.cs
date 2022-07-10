using BookStore.Models.Models;
using BookStore.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Repositories
{
    
   public class RoleRespository
    {
        BookstoreContext _context = new BookstoreContext();
        public ListResponse<Role> getAllRoles()
        {
            var list = _context.Roles.ToList();
            int totalRecords = list.Count();
            return new ListResponse<Role>() {
                Results = list,
                TotalRecords = totalRecords,
        };
        }
    }
}
