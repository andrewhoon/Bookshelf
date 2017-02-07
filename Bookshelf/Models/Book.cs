using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; //added this
using System.ComponentModel.DataAnnotations.Schema;  //added this also

namespace Bookshelf.Models
{
    public class Book
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime PublishedDate { get; set; }
        public string Description { get; set; }
        public string ISBN { get; set; }


        [ForeignKey("Category")]    
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }  //in category.cs, creating that field eliminated squiggly line under category






    }
}