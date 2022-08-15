using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryPro.Models
{
    class BooksDataModel
    {
        public int Book_Id { get; set; }
        public string Book_Name { get; set; }
        public string Book_Author { get; set; }
        public int Book_PageNumber { get; set; }
        public int Book_country { get; set; }
    }
}
