using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TeamDeliriumProject.Data.Identity;

namespace TeamDeliriumProject.Data.Entities
{
    public class Post
    {
        [Key]
        public int id;
        [Required]
        public string title;

        [Required]
        public string description;

        public User creator;

        public List<Comment> comments;

        //public int likes;

    }
}
