using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap.Posts.Domain.Entities
{
    public class Posts
    {
        //Binary Json
        [BsonId]
        [BsonRepresentation(BsonType.String)]
        public Guid ItemId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime? LastUpdatedDate { get; set; }
        public string LastUpdatedBy { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public bool IsArchive { get; set; }
        public string CategoryName { get; set; }
        public string CategoryName5 { get; set; }

        public string CategoryName9 { get; set; }


    }
}
