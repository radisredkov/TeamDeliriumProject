using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TeamDeliriumProject.Data.Entities
{
    public class Comment
    {
        [Key]
        public int id;
        [Required]
        public string content;

       // public int likes;
    }
}
