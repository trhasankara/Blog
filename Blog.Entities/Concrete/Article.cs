using Blog.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Entities.Concrete
{
    public class Article : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime? CreateDate { get; set; }
        public int CategoryId { get; set; }
        public int ViewCount { get; set; }
        public int LikeCount { get; set; }
        public int AuthorId { get; set; }
    }
}
